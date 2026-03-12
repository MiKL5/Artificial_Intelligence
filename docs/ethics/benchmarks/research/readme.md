# Comment les chercheurs améliorent-ils la compréhension des modèles ? <a href="https://github.com/MiKL5/"><img src="../../../../assets/images/atomicAi.png" alt="L'intelligence artificielle" align="right" height="64px"></a>

Face à la croissance des architectures de type *boîte noire*, la communauté scientifique a structuré une discipline entière — l'**interprétabilité** — articulée autour de deux axes complémentaires : comprendre *ce que* le modèle calcule, et expliquer *pourquoi* il produit une sortie particulière.
---

## Sommaire

* [Modèles intrinsèquement lisibles](#modèles-intrinsèquement-lisibles)
* [Attributions post-hoc : LIME et SHAP](#attributions-post-hoc--lime-et-shap)
* [Gradient-based : saliency maps et Grad-CAM](#gradient-based--saliency-maps-et-grad-cam)
* [Interprétabilité mécaniste](#interprétabilité-mécaniste)
* [Activation Steering et vecteurs directionnels](#activation-steering-et-vecteurs-directionnels)
* [Visualisation des mécanismes d'attention](#visualisation-des-mécanismes-dattention)
* [Probing classifiers](#probing-classifiers)
* [Enjeux réglementaires et éthiques](#enjeux-réglementaires-et-éthiques)

___

## Modèles intrinsèquement lisibles

Certaines architectures exposent leur logique par construction. Les arbres de décision, les régressions linéaires et les systèmes à règles sont dits *interprétables intrinsèquement* : aucun outillage externe n'est nécessaire pour auditer leur fonctionnement.  
Leur limite est connue — la capacité représentationnelle croît difficilement au-delà de problèmes de faible dimensionnalité, ce qui a poussé les chercheurs vers des méthodes *post-hoc* applicables à tout type d'architecture.

## Attributions post-hoc : LIME et SHAP

### LIME — *Local Interpretable Model-Agnostic Explanations*

**LIME** exploite la régularité locale : même si la frontière de décision globale est non-linéaire, un voisinage réduit autour d'un point reste souvent approximable par un modèle linéaire.  
L'algorithme génère des perturbations dans ce voisinage, les pondère par proximité à l'instance cible, puis ajuste un modèle transparent sur ces échantillons synthétiques.

> ⚠️ **Limite majeure** : instabilité — deux exécutions sur la même instance peuvent produire des explications contradictoires.

### SHAP — *SHapley Additive exPlanations*

**SHAP** repose sur la théorie des jeux coopératifs et distribue équitablement la contribution de chaque variable à la prédiction.  
Contrairement à LIME, les valeurs de Shapley bénéficient de garanties théoriques solides (efficacité, symétrie, factice), mais à un coût computationnel significatif.

<details>
<summary>Quand combiner LIME et SHAP ?</summary>

Méthode | Usage recommandé | Complexité
---|---|---
**LIME** | Exploration rapide, prototypage | Faible
**SHAP** | Attribution rigoureuse, production | Élevée
**Les deux** | Audit complet, conformité IA Act | Modérée à élevée

La combinaison reste courante : LIME pour l'exploration, SHAP pour l'attribution formellement justifiable.

</details>

## Gradient-based : saliency maps et Grad-CAM

Pour les réseaux profonds différentiables, les chercheurs calculent le gradient de la sortie par rapport à l'entrée — les pixels à fort gradient signalant les zones les plus déterminantes dans la décision.

Deux raffinements dépassent les cartes de saliency brutes, sujettes à la saturation des gradients et au bruit haute-fréquence :

* **Integrated Gradients** — accumule les gradients le long d'un chemin linéaire entre une référence neutre et l'entrée réelle, garantissant la *complétude* de l'attribution
* **Grad-CAM** — projette les gradients sur les cartes d'activation de la dernière couche convolutive, produisant une carte de chaleur plus sémantique et moins bruitée

## Interprétabilité mécaniste

L'approche la plus récente — et la plus ambitieuse — procède par rétro-ingénierie du modèle : identifier les **features** (directions dans l'espace d'activation encodant des concepts), puis les **circuits** (sous-graphes computationnels responsables d'un comportement particulier).

L'équipe d'Anthropic a popularisé cette méthodologie via les travaux sur les *Transformer Circuits*. La notion d'**universalité** — l'hypothèse que les mêmes circuits émergent dans des modèles distincts — est au cœur des enjeux : si elle se vérifie, les découvertes deviennent transférables sans réanalyser chaque modèle individuellement.

<details>
<summary>Techniques d'investigation causale</summary>

Des techniques comme le **path patching**, la **residual stream tracing** et l'**activation substitution** permettent de tester causalement l'implication d'un circuit dans un comportement donné, apportant une reproductibilité que les méthodes corrélatives ne garantissent pas.

</details>


## Activation Steering et vecteurs directionnels

L'**activation steering** injecte un vecteur directionnel dans le *residual stream* d'un LLM à l'inférence, modifiant le comportement du modèle sans réentraînement.  
Les *steering vectors* sont construits en soustrayant les activations induites par deux prompts antagonistes — par exemple `positif` vs. `négatif` — et peuvent ensuite moduler le registre ou la sécurité des sorties.

> Cette technique repose sur l'**hypothèse de représentation linéaire** : les concepts seraient encodés comme des directions dans l'espace des embeddings.

## Visualisation des mécanismes d'attention

Dans les Transformers, les poids d'attention semblent offrir une fenêtre naturelle sur les dépendances capturées — intuition qui a alimenté de nombreux travaux de débogage syntaxique.

> ⚠️ **Mise en garde** : l'attention est souvent surinterprétée. Les poids d'attention ne constituent pas une explication causale suffisante ; ils peuvent se concentrer sur des artefacts de position ou de formatage plutôt que sur la sémantique.

## Probing classifiers

Les *probing classifiers* testent si une représentation intermédiaire encode linéairement un concept donné — par exemple la notion de verbe ou de polarité — en entraînant un classifieur simple sur les activations internes.  
Cette méthode, dite d'*interprétabilité basée sur les concepts*, opère à un niveau d'abstraction supérieur à la décomposition neuronale et s'articule bien avec l'analyse mécaniste.

## Enjeux réglementaires et éthiques

L'**IA Act** européen et le **RGPD** positionnent l'explicabilité comme une obligation, non une option : le droit à l'explication des décisions automatisées impose aux systèmes déployés une auditabilité minimale.  
La transparence n'est donc pas seulement un objectif épistémique — elle conditionne la conformité légale de tout modèle pris en production dans l'Union européenne.

<details>
<summary>Articles de référence — RGPD & IA Act</summary>

Texte | Disposition | Portée
---|---|---
**RGPD** | Art. 22 | Droit de ne pas faire l'objet d'une décision automatisée
**RGPD** | Art. 13-14 | Information sur la logique sous-jacente
**IA Act** | Art. 13 | Transparence des systèmes IA à haut risque
**IA Act** | Art. 14 | Supervision humaine

</details>

___

> Sources  
1 [IBM — Qu'est-ce que l'interprétabilité de l'IA](https://www.ibm.com/fr-fr/think/topics/interpretability) ➜ Article technique  
2 [Nexa — IA explicable (XAI) : définition](https://www.nexa.fr/blog/ia-explicable-xai-definition) ➜ Article technique  
3 [Learn Prompting — AI Interpretability with LIME and SHAP (2026)](https://www.learn-prompting.fr/blog/ai-interpretability-lime-shap) ➜ Guide pratique  
4 [Meritis — Interprétation des modèles IA avec LIME et SHAP](https://meritis.fr/interpretation-des-modeles-ia-avec-les-methodes-lime-et-shap/) ➜ Article technique  
5 [DataAnnotation — Which Explainable AI Methods Work?](https://www.dataannotation.tech/blog/explainable-ai-methods) ➜ Évaluation empirique  
6 [Anthropic — Transformer Circuits Thread](https://transformer-circuits.pub) ➜ Recherche fondamentale  
7 [arXiv — A Practical Review of Mechanistic Interpretability for Transformers](https://arxiv.org/html/2407.02646v4) ➜ Revue scientifique  
8 [arXiv — Mechanistic Unveiling of Transformer Circuits](https://arxiv.org/html/2502.09022v1) ➜ Recherche fondamentale  
9 [Cognaptus — Circuits of Understanding](https://cognaptus.com/blog/2025-07-30-circuits-of-understanding-a-formal-path-to-transformer-interpretability/) ➜ Article de synthèse  
10 [Auroria — Advanced Feature Attribution Techniques](https://www.auroria.io/advanced-feature-attribution-techniques-for-deep-learning-models/) ➜ Guide technique  
11 [Emergent Mind — Gradient-Based Saliency Maps](https://www.emergentmind.com/topics/gradient-based-saliency-maps) ➜ Référence technique  
12 [Emergent Mind — Activation Steering in LLMs](https://www.emergentmind.com/topics/activation-steering-method) ➜ Référence technique  
13 [Towards Data Science — Mechanistic Interpretability: Peeking Inside an LLM](https://towardsdatascience.com/mechanistic-interpretability-peeking-inside-an-llm/) ➜ Article pédagogique  
14 [arXiv — ExpertLens: Activation steering features](https://arxiv.org/html/2502.15090v4) ➜ Recherche appliquée  
15 [Hello Future Orange — Approche contextuelle de l'explicabilité](https://hellofuture.orange.com/fr/pour-une-approche-contextuelle-de-lexplicabilite-de-lia/) ➜ Article de synthèse  
16 [CANSSI — Marouane Il Idrissi : débloquer l'explicabilité](https://incass.ca/story/bpdi-2025-marouane-il-idrissi/) ➜ Actualité recherche  
17 [NeurIPS 2024 — Transcoders find interpretable LLM feature circuits](https://neurips.cc/virtual/2024/poster/95736) ➜ Conférence scientifique  
18 [ANR — Théorie et algorithmes pour la compréhension du deep learning](https://anr.fr/Projet-ANR-20-CE23-0020) ➜ Projet de recherche
<!-- ___
> *Document rédigé dans le cadre d'une veille scientifique sur l'interprétabilité des modèles d'apprentissage automatique.*  
> *Dernière mise à jour : mars 2026.* -->