# **Les LSTM**<a href="../../"><img src="../../../assets/images/atomicAi.png" alt="L'intelligence artificielle" align="right" height="64px"></a>
L'architecture **LSTM** (*Long Short-Term Memory*), introduite par **Hochreiter et Schmidhuber** en 1997, constitue une réponse ingénieuse aux limitations structurelles des Réseaux de Neurones Récurrents (RNN) standards. Conçus pour modéliser des dépendances temporelles à long terme, les LSTM ont dominé le traitement du langage naturel (NLP) et l'analyse de séries temporelles pendant deux décennies, avant l'avènement des mécanismes d'attention (Transformers). Ce cours dissèque leur anatomie interne, notamment le mécanisme de "portage" (*gating*), qui leur permet de s'affranchir du fléau de l'évanouissement du gradient.
---

## Problématique : L'Amnésie des RNN Standards

Pour comprendre le LSTM, il faut d'abord diagnostiquer la pathologie du RNN classique (*Vanilla RNN*).

Lors de la **rétropropagation à travers le temps** (*Backpropagation Through Time* - BPTT), le gradient de l'erreur est multiplié successivement par la matrice de poids récurrente $W_{hh}$.
* Si la valeur propre dominante de $W_{hh}$ est $< 1$, le gradient tend exponentiellement vers zéro : c'est l'**évanouissement du gradient** (*Vanishing Gradient*). Le réseau "oublie" les entrées lointaines (le début de la phrase).
* Si elle est $> 1$, le gradient explose (*Exploding Gradient*).

> **Analogie doctorale :** Un RNN standard est comme une personne atteinte de troubles de la mémoire immédiate : il traite l'instant présent mais perd le contexte narratif dès que la séquence s'allonge. Le LSTM est doté d'un carnet de notes (la *Cell State*) qu'il peut consulter, effacer ou enrichir sélectivement.

## Anatomie d'une Cellule LSTM

Contrairement au neurone standard qui applique une simple tangente hyperbolique ($\tanh$), la cellule LSTM est un circuit complexe régulé par des portes (*gates*).

### La "Cell State" ($C_t$) : L'Autoroute de l'Information
C'est l'innovation majeure. L'état de la cellule traverse la chaîne séquentielle avec des interactions linéaires mineures. Cela permet au gradient de circuler sans s'altérer, résolvant le problème de l'évanouissement[^1].

### Le Mécanisme de Portage (Gating)
Trois portes, composées de couches sigmoïdes ($\sigma$), régulent le flux d'information (la sigmoïde sort une valeur entre 0 et 1, agissant comme une vanne physique).

#### La Porte d'Oubli (*Forget Gate* - $f_t$)
Décide quelle information de l'état précédent ($C_{t-1}$) est devenue obsolète.
$$f_t = \sigma(W_f \cdot [h_{t-1}, x_t] + b_f)$$
*Exemple linguistique :* Si le sujet de la phrase change de "Il" à "Elles", la porte d'oubli efface l'information "genre masculin".

#### La Porte d'Entrée (*Input Gate* - $i_t$)
Décide quelle nouvelle information stocker dans l'état de la cellule.
1.  La couche sigmoïde ($i_t$) décide *quelles* valeurs mettre à jour.
2.  Une couche $\tanh$ crée un vecteur de nouvelles valeurs candidates ($\tilde{C}_t$).
$$C_t = f_t * C_{t-1} + i_t * \tilde{C}_t$$

#### La Porte de Sortie (*Output Gate* - $o_t$)
Décide ce que le neurone va émettre vers la couche suivante et vers l'étape temporelle suivante ($h_t$), basé sur l'état filtré de la cellule.
$$h_t = o_t * \tanh(C_t)$$

## Variantes et Évolution

### Le GRU (Gated Recurrent Unit)
Proposé par **Cho et al.** en 2014. C'est une simplification élégante du LSTM. Il fusionne la porte d'oubli et d'entrée en une seule porte de "mise à jour".
* **Avantage :** Moins de paramètres, entraînement plus rapide, performances souvent équivalentes.

### 2. Le Bi-LSTM (Bidirectionnel)
Il traite la séquence dans les deux sens (passé vers futur et futur vers passé).
* **Usage :** Indispensable pour la reconnaissance d'entités nommées (NER), où le contexte futur est aussi important que le passé pour désambiguïser un mot (ex: "Apple" est-il un fruit ou une entreprise ? La réponse est souvent après le mot).

## IV. LSTM vs Transformers : La Relève de la Garde

Depuis 2017 (papier *Attention is All You Need*), les **Transformers** ont supplanté les LSTM dans le NLP moderne.

Critère | LSTM | Transformer
---|---|---
**Traitement** | Séquentiel ($O(N)$) | Parallèle ($O(1)$ pour l'inférence)
**Mémoire** | Limitée (dégradation sur séquences très longues) | Théoriquement infinie (fenêtre contextuelle)
**Entraînement** | Lent (difficile à paralléliser sur GPU) | Très rapide et scalable
**Usage Actuel** | Séries temporelles, Edge AI, faible ressource | LLM, Vision, Génération

> **Nota** Ne commettez pas l'erreur de considérer le LSTM comme "mort". Dans des environnements contraints (IoT, embarqué) ou sur des datasets de séries temporelles numériques (finance, météo) où la localité séquentielle prime, le LSTM reste souvent plus robuste et moins énergivore qu'un Transformer massif.
___
>Sources
>**Textes Fondateurs**
>1.  **Hochreiter, S., & Schmidhuber, J.** (1997). *Long Short-Term Memory*. Neural Computation. (L'article séminal, lecture obligatoire pour tout doctorant).
>2.  **Cho, K., et al.** (2014). *Learning Phrase Representations using RNN Encoder-Decoder for Statistical Machine Translation*. EMNLP. (Introduction des GRU).
>
>**Littérature Technique & Pédagogique**  
>3.  **Olah, C.** (2015). *Understanding LSTM Networks*. Colah's Blog. (Probablement la meilleure explication visuelle jamais produite).  
>4.  **Goodfellow, I., Bengio, Y., & Courville, A.** (2016). *Deep Learning*. MIT Press. (Chapitre 10 : Sequence Modeling).  
>5.  **Google Brain.** (2016). *Google's Neural Machine Translation System: Bridging the Gap between Human and Machine Translation*. (Le déploiement massif des LSTM chez Google avant les Transformers).
___
[^1]: **Orthogonalité du flux d'erreur** : Dans l'espace des gradients, le LSTM maintient une erreur qui ne s'effondre pas grâce à la porte d'oubli qui peut agir comme une fonction identité (laisser tout passer), préservant ainsi la magnitude du signal d'erreur lors de la rétropropagation sur de très longues séquences.