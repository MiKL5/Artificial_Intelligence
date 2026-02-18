# **Le Traitement Automatique du Langage Naturel**<a href="../../"><img src="../../../assets/images/atomicAi.png" alt="L'intelligence artificielle" align="right" height="64px"></a>
## **Introduction ➜ L'Ambiguïté Fondamentale**
Le langage humain se distingue des langages formels par son ambigüité intrinsèque, sa polysémie et sa dépendance contextuelle. Le NLP vise à modéliser cette complexité pour permettre à une machine d'analyser, de comprendre et de générer du texte.

L'analyse linguistique s'opère sur plusieurs strates hiérarchiques :
1.  **Morphologie :** Étude de la structure interne des mots (lemmes, morphèmes).
2.  **Syntaxe :** Étude des règles régissant l'agencement des mots (grammaire, arbres de dépendance).
3.  **Sémantique :** Étude du sens (désambiguïsation, entités nommées).
4.  **Pragmatique :** Étude du sens en contexte (ironie, intentions, actes de langage).
## **Évolution Historique des Paradigmes**
L'histoire du NLP peut être segmentée en trois ères distinctes, marquant le passage de la règle explicite à l'apprentissage latent.
### **L'Approche Symbolique (1950s - 1980s)**
Cette approche, fortement influencée par les travaux de **Noam Chomsky** sur les grammaires génératives, reposait sur des règles manuelles (*Hard-coded rules*).
* **Méthode :** Systèmes experts, ontologies, règles `if-then-else`.
* **Limites :** Incapacité à gérer l'exception, l'argot ou les tournures idiomatiques. Le "bottleneck" de la connaissance.
### **L'Approche Statistique (1990s - 2010s)**
L'avènement des corpus numérisés a permis l'émergence de modèles probabilistes.
* **Concepts clés :** Modèles N-grammes, Chaînes de Markov Cachées (HMM).
* **Principe :** Calculer la probabilité d'occurrence d'une suite de mots $P(w_1, w_2, ..., w_n)$.
### **L'Approche Neuronale (2013 - Présent)**
L'introduction du *Deep Learning* a révolutionné le traitement sémantique.
* **Word Embeddings (Plongements lexicaux) :** Représentation des mots sous forme de vecteurs denses dans un espace vectoriel continu (ex: Word2Vec, GloVe). L'hypothèse distributionnelle de **Harris (1954)** est ici centralisée : *"You shall know a word by the company it keeps"*.
    * Algébriquement, on observe des relations telles que : $\vec{Roi} - \vec{Homme} + \vec{Femme} \approx \vec{Reine}$.
## **L'Architecture Transformer et les LLM**
Le véritable point d'inflexion moderne est la publication du papier *"Attention Is All You Need"* (2017), introduisant l'architecture **Transformer**.
### **Le Mécanisme d'Attention (*Self-Attention*)**
Contrairement aux réseaux récurrents (RNN/LSTM) qui traitaient les séquences séquentiellement (interdisant la parallélisation massive), le Transformer traite l'ensemble de la séquence simultanément. Le mécanisme d'attention permet au modèle de pondérer l'importance relative de chaque mot par rapport aux autres, quelle que soit leur distance dans la phrase.

L'équation fondamentale de l'attention scalée est :

$$Attention(Q, K, V) = softmax\left(\frac{QK^T}{\sqrt{d_k}}\right)V$$

Où $Q$ est la requête (*Query*), $K$ la clé (*Key*) et $V$ la valeur (*Value*).

### **BERT, GPT et le *Pre-training***
Cette architecture a permis l'émergence des **Large Language Models (LLM)** :
* **BERT (Bidirectional Encoder Representations from Transformers) :** Modèle non-causal (bidirectionnel), idéal pour la compréhension (classification, extraction d'entités).
* **GPT (Generative Pre-trained Transformer) :** Modèle causal (autorégressif), conçu pour la génération de texte (prédire le mot suivant).

Ces modèles utilisent l'apprentissage par transfert (*Transfer Learning*) : ils sont pré-entraînés sur des corpus massifs (le Web) pour acquérir une "compréhension" générale, puis affinés (*Fine-tuned*) pour des tâches spécifiques.
## **Défis Éthiques et Limites**
Malgré leurs performances (passant le Test de Turing dans de nombreuses configurations), ces modèles ne sont pas exempts de critiques fondamentales.

* **Hallucinations :** Génération de faits plausibles mais faux. Le modèle est un "perroquet stochastique" qui ne comprend pas la vérité, mais la probabilité.
* **Biais Algorithmiques :** Les modèles encodent et amplifient les stéréotypes présents dans les données d'entraînement (racisme, sexisme).
* **Coût Énergétique :** L'entraînement d'un LLM consomme des centaines de mégawattheures.
___
> **Bibliographie et Références**
> 1.  **Turing, A. M.** (1950). *Computing Machinery and Intelligence*. Mind, 59(236), 433-460. [Lien vers l'article](https://academic.oup.com/mind/article/LIX/236/433/986238) - (Le fondement philosophique).
> 2.  **Chomsky, N.** (1957). *Syntactic Structures*. Mouton. [Lien vers le contexte](https://mitpress.mit.edu/9780262531049/syntactic-structures/) - (La base de la linguistique formelle).
> 3.  **Mikolov, T., Chen, K., Corrado, G., & Dean, J.** (2013). *Efficient Estimation of Word Representations in Vector Space*. arXiv preprint arXiv:1301.3781. [Lien vers arXiv](https://arxiv.org/abs/1301.3781) - (Introduction de Word2Vec).
> 4.  **Vaswani, A., Shazeer, N., Parmar, N., Uszkoreit, J., Jones, L., Gomez, A. N., ... & Polosukhin, I.** (2017). *Attention Is All You Need*. Advances in neural information processing systems. [Lien vers arXiv](https://arxiv.org/abs/1706.03762) - (Le papier fondateur des Transformers).
> 5.  **Devlin, J., Chang, M. W., Lee, K., & Toutanova, K.** (2018). *BERT: Pre-training of Deep Bidirectional Transformers for Language Understanding*. arXiv preprint arXiv:1810.04805. [Lien vers arXiv](https://arxiv.org/abs/1810.04805).
> 6.  **Bender, E. M., Gebru, T., McMillan-Major, A., & Shmitchell, S.** (2021). *On the Dangers of Stochastic Parrots: Can Language Models Be Too Big?*. Proceedings of the 2021 ACM Conference on Fairness, Accountability, and Transparency. [Lien vers ACM Digital Library](https://dl.acm.org/doi/10.1145/3442188.3445922) - (Critique éthique majeure).