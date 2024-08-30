# **Le benchmark SuperGLUE (`Super General Language Understanding Evaluation`)**
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
3. Dépassement des performances humaines  
   Certains modèles ont dépassés les performances humaines moyennes avec SuperGLUE. Nonobstant, cela ne veut pas dire que ces modèles comprennent de la même façon le langage. Ils sont capables de détecter et explorer des patterns dans les données de manière très efficace. Cela reste très différent de la compréhension humaine.
4. Limites de modèles  
   La généralisation à des tâches ou contextes non vus, le raisonnement à des concepts complexes, la compréhension nuancée ou contextuelle.

_**⟹ Les performance via un benchmark ne capture pas toutes les nuances de la compréhension des langages humains.**_