# **Le benchmark SuperGLUE (`Super General Language Understanding Evaluation`)** <a href="https://github.com/MiKL5/"><img src="../../../../assets/images/atomicAi.png" alt="L'intelligence artificielle" align="right" height="64px"></a></h1>
C’est un ensemble de tests évaluant les capacités de compréhension du langage naturel des système d’IA. Son but est de remplacer GLUE, trop facile pour les modèles récents.
## **La caractéristique principales**
1. Les tâches sont plus difficiles  
   Il conserve les 2 tâches les plus dures de GLUE, en a de nouvelles plus complexes (la résolution de coréférences, question/réponse, …)
2. Les formats de tâches sont plus diversifiés  
   Avec tâches de classification de phrases et paire de phrases, les formats de tâches sont plus variés. 
3. L’évaluation humaine de référence  
4. Un meilleur support logiciel  
   Ce benchmark a une nouvelle boîte à outils modulaire pour le pré-entraînement, l’apprentissage multi-tâches et le transfert d’apprentissage en TAL (Traitement Automatique des Langues).
5. Les règles d’utilisation sont affinées  
   Les conditions d’inclusions sur le classement permettent désormais d’assurer une compétition équitable et un classement informatif.

_**⟹ Il fournit une évaluation plus diversifiée et rigoureuse des capacités de compréhension du langage naturel des systèmes d’IA, grâce à des défis plus difficiles que GLUE.**_
## **La comparaison des modèles au performances humaines**
1. Le niveau de performance des modèles  
   Les modèles de langage avancés, comme ceux étant basés sur l’architecture [Transformer](../../../seq2Seq/transformers), tel que GPT-4, T5 et BERT amélioré, et cætera ont atteint des scores très élevés avec SuperGLUE ont dépassés 90 sur 100. Cent étant parfait.
2. Performance humaines via SuperGLUE  
   * Il permet une estimation des performances humaines généralement considérées comme une ligne de base ”à dépasser”. Dans ce benchmark, elles sont d’environ 89-90.  
   * Les capacités de compréhension contextuelle et de raisonnement humaines sont très solides, malgré nos erreurs.
3. Le dépassement des performances humaines  
   Certains modèles ont dépassé les performances humaines moyennes avec SuperGLUE. Nonobstant, cela ne veut pas dire que ces modèles comprennent le langage de la même façon. Ils sont capables de repérer et explorer des patterns dans les données de manière très efficace. Cela reste très différent de la compréhension humaine.
4. Limites de modèles  
   La généralisation à des tâches ou contextes non connus, le raisonnement à des concepts complexes, la compréhension nuancée ou contextuelle.

_**⟹ Les performance via un benchmark ne capture pas toutes les nuances de la compréhension des langages humains.**_
## **Les tâches de SuperGLUE**
* Le diagnostic à large couverture (AX-b)
* La banque d’engagement (CB)
* Le choix d’alternatives plausibles (COPA)  
  Tester le raisonnement causal en sélectionnant la bonne option sur la base d’une relation de cause à effet.
* La compréhension de la lecture de phrases multiples (MultiRC)  
  Test la compréhension de la lecture en demandant aux modèles de répondre à des questions à choix multiples basées sur un passage.
* La reconnaissance de l’implication textuelle (RTE)  
  Similaire à la tâche du GLUE, cette tâche consiste à déterminer la relation d’implication entre les paires de phrases.
* Les mots en contexte (WiC)  
  Évalue la compréhension des modèles de l’utilisation des mots dans différents contextes en déterminant si un mot a le même sens dans deux phrases.
* Le Winograd Schema Challenge (WSC)  
  Évalue la capacité des modèles à résoudre les pronoms en comprenant le contexte d’une phrase.
* BoolQ  
  Évalu la capacité des modèles à répondre à des questions booléennes sur la base de passages fournis.
* La compréhension de la lecture avec raisonnement de bon sens (ReCoRD)  
  Une tâche qui évalue la compréhension de la lecture en demandant aux modèles de raisonner avec des connaissances de bon sens.
* Winogender Schema Diagnostics (AX-g)
## **Les limites de SuperGLUE**
* La couverture limitée  
  Il ne couvre pas toutes les formes de tâches de compréhension du langage. Retenant que 2 des 9 tâches de GLUE, il ne représente peut-être pas pleinement la diversité et la complexité de la compréhension du langage.
* La différence de distribution  
  La différence de distribution entre l’ensemble d’apprentissage et l’ensemble de test de validation peut limiter les performances attendues des modèles.
* L’uniformité  
  Le format de SuperGLUE est moins uniforme que celui de son prédécesseur, GLUE. Pouvant potentiellement décourager certains chercheurs qui étaient attirés par le cadre très uniforme de GLUE.
* La taille de l’ensemble de données  
  Les ensembles de données de SuperGLUE sont moins volumineux que ceux d’autres benchmarks. Pouvant potentiellement réduire la portée des types de travaux évalués ici. Nonobstant, cela pourrait également abaisser la barrière informatique à l’entrée, ce qui pourrait démocratiser la recherche sur ce benchmark.
* Les performances des modèles  
  Certains modèles d’IA de grandes entreprises technologiques comme Microsoft et Google ont déjà surpassé les performances humaines lors de ce test de référence linguistique SuperGLUE. Cela questionne quant à la capacité du test à continuer de repousser les limites des modèles de compréhension du langage.
* Les biais  
  Malgré les efforts pour minimiser les biais, certains peuvent rester dans les tâches et les ensembles de données inclus dans SuperGLUE.
___
>>> Source  
[Code Labs Academy](https://codelabsacademy.com/fr/blog/what-is-the-superglue-benchmark)  
[Klu](https://klu.ai/glossary/superglue-eval)