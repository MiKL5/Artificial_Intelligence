# **L'Apprentissage Automatique**<a href="../../"><img src="../../../assets/images/atomicAi.png" alt="L'intelligence artificielle" align="right" height="64px"></a>
## **Fondements Théoriques ➜ L'Approche Statistique**
Contrairement à la programmation déterministe, où les règles sont explicitement codées ($Si... Alors...$), le Machine Learning induit des règles à partir de l'observation empirique. Selon **Tom Mitchell (1997)** ➜
> "On dit qu'un programme apprend de l'expérience `E` par rapport à une classe de tâches `T` et une mesure de performance `P`, si sa performance sur `T`, mesurée par `P`, s'améliore avec l'expérience `E`."

L'objectif central est la **généralisation** est la capacité du modèle à performer sur des données non vues (*out-of-sample*), en minimisant l'erreur empirique tout en contrôlant la complexité du modèle pour éviter le sur-apprentissage (*overfitting*).
## **Taxinomie des Paradigmes d'Apprentissage**
### **1. Supervised Learning**
Le modèle apprend une fonction de mappage $f: X \to Y$ à partir de paires entrée-sortie étiquetées.
* **Régression**  
Prédiction d'une variable continue (e.g. prix d'un actif).
* **Classification**  
Prédiction d'une classe discrète (e.g. diagnostic médical).
* **Algorithmes notables**  
Support Vector Machines (SVM), Forêts Aléatoires (Random Forests), Réseaux de Neurones.
### **2. Unsupervised Learning**
L'algorithme explore la structure sous-jacente de données non étiquetées. Il n'y a pas de variable cible $Y$.
* **Clustering (Partitionnement)**  
Regroupement de données similaires (ex: K-Means, DBSCAN).
* **Réduction de dimensionnalité**  
Compression de l'information (ex: PCA - Analyse en Composantes Principales).
### **3. Reinforcement Learning***
Un agent apprend à prendre des décisions séquentielles dans un environnement en maximisant une récompense cumulée. C'est le paradigme du vivant (essai-erreur).
* _Application_ ➜ Robotique, Trading algorithmique, AlphaGo.
## **Le Deep Learning ➜ L'Avènement du Connexionnisme**
Le *Deep Learning* (Apprentissage Profond) est une sous-catégorie du ML utilisant des réseaux de neurones artificiels (ANN) à multiples couches cachées. Cette architecture permet l'apprentissage de représentations hiérarchiques de haut niveau (e.g. bords -> formes -> objets).
* **Rétropropagation du gradient (_Backpropagation_)**  
L'algorithme clé permettant d'ajuster les poids synaptiques du réseau en minimisant une fonction de perte (_Loss Function_) via le calcul différentiel (règle de la chaîne).
## **Méthodologie et Rigueur Scientifique**
La mise en œuvre d'un modèle ML exige une rigueur protocolaire stricte pour assurer la validité scientifique des résultats.
1.  **Préparation des données (_Feature Engineering_)**  
Normalisation, gestion des valeurs manquantes, encodage des variables catégorielles.
2.  **Séparation des données**  
Train (Entraînement) / Validation (Réglage des hyperparamètres) / Test (Évaluation finale).
3.  **Métriques d'évaluation**  
Accuracy, F1-Score, AUC-ROC, RMSE (selon le problème).
## **Éthique et Explicabilité (XAI)**
L'utilisation de modèles complexes (comme les réseaux profonds) pose le problème de l'opacité (*Black Box*).
* **Droit à l'explication**  
Le RGPD impose une certaine transparence sur les décisions automatisées (considérant 22 et articles 13-15).
* **Biais algorithmiques**  
Les modèles reproduisent, voire amplifient, les biais sociologiques présents dans les données d'entraînement (e.g. biais raciaux dans la reconnaissance faciale). L'audit des datasets est une obligation éthique.
___
> Sources
> 1.  **Bishop, C. M.** (2006). *Pattern Recognition and Machine Learning*. Springer. (La référence absolue pour l'approche probabiliste).
> 2.  **Goodfellow, I., Bengio, Y., & Courville, A.** (2016). *Deep Learning*. MIT Press.
> 3.  **Hastie, T., Tibshirani, R., & Friedman, J.** (2009). *The Elements of Statistical Learning: Data Mining, Inference, and Prediction*. Springer.
> 4.  **Vapnik, V. N.** (1995). *The Nature of Statistical Learning Theory*. Springer-Verlag. (Fondements de la théorie VC).
> 5.  **Russell, S. J., & Norvig, P.** (2020). *Artificial Intelligence: A Modern Approach* (4th ed.). Pearson.