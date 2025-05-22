# **Le Fine-tuning**<a href="../../"><img src="../../../assets/images/atomicAi.png" alt="Les intelligences artificielles" align="right" height="64px"></a>
Cela signifie le régalge fin et c’est essentiel au développement et déploiement de modèle d’apprentissage automatique (notament les NLP).  
Il s’agit d’adapter un modèle pré-entraîné à faire des tâches spécifiques ou améliorer les performances sur des ensembles de données particuliers. Il exploite les vaste connaissances des LLM en les adaptants aux besoins particuliers.
## **Le processus**
1. Sélectinner un mocèles pré-entraîné (e.g. GPT4 ou BERT) ;
2. Préparer l’ensemble de données <!--  : L'ensemble doit être bien étiqueter et de grande qualité pour que le fine-tuning soit efficace. -->;
3. Ajuster le modèle <!-- : Le nouvel eneble de données sert à ré-entraîner le modèle de données, mettre à jour les poids et biais du modèles pour mieux l'adapter à une tâche spécifique. -->;
4. Evaluer et répéter<!-- : En permance le modèle doit être évaluer sur un ensemble de validations et répéter le processus d'entraînement. Ajuster les paramètres et modifier l'ensemble de données, puis affine les réglages au besoin. -->.
## **Les étapes techniques**
1. Le gel des couches<!--  : les premières couches ne sont pas entraîner pour conserver la compréhension générale de la langue et d'autres sont affinées pour les tâches spédifiques. --> ;
2. Le réglage du taux d’apprentissage<!-- : Le taux d'apprentissage est minutieusement gérer (pour la plupart des projets). Le but du taux d'apprentissage faible est d'éviter l'oubli des connaissances précédement acquises. --> ;
3. Les techniques de régularisation<!--  : l'abandont ou le drop-out, la décroissances deds poinds... servent à éviter le suraprentissage ou l'overfiting lors du fine-tuning et veiller que le modèle et généraliser à des données inédites.-->.