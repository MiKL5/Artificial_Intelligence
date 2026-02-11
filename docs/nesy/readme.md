# **L’IA neuro symbolique** <a href="../"><img src="../../assets/images/atomicAi.png" alt="Les intelligences artificielles" align="right" height="64px"></a>
L’**IA Neuro-Symbolique** (souvent désignée par l’acronyme **NeSy**) est le cœur technologique de la **troisième Vague de l’intelligence artificielle**. C’est une architecture hybride visant à réconcilier les deux paradigmes historiques de l’IA : le raisonnement logique (l’IA symbolique) et l’apprentissage statistique (les réseaux de neurones).

Son objectif fondamental est de dépasser les limites des “boîtes noires” actuelles pour produire des systèmes capables d’*Adaptation Contextuelle*, alliant la robustesse de la perception à la rigueur de l’explicabilité.
### **1. Le Principe : L’Hybridation des “Deux Cerveaux”**
Le but de l’IA NeSy est la combinaison du meilleur des deux mondes précédents pour émuler la cognition humaine complète :
* **Le Système 1 (Intuitif) :** Issu de la deuxième vague (Deep Learning), il gère la *perception*. Il est rapide, intuitif et capable de généraliser à partir de données brutes (images, textes), mais il reste opaque et sujet aux [hallucination (confabulation en vrai)](confabulation).
* **Le Système 2 (Analytique) :** Issu de la première vague (Symbolique), il gère le *raisonnement*. Il est lent, rigoureux et basé sur des règles logiques explicites, mais il est trop rigide pour gérer le flou du monde réel.

L’IA NeSy fait collaborer ces deux systèmes : le réseau de neurones perçoit le monde et génère des intuitions, tandis que le moteur symbolique valide ces intuitions et structure le raisonnement.
### **2. Architectures Techniques**
L’intégration de la logique et des neurones se fait principalement via deux approches techniques :
* **L’Apprentissage Contraint par la Logique :** On intègre des règles logiques directement dans la fonction de perte (loss function) du réseau de neurones lors de son entraînement. Cela force l’IA à apprendre des représentations qui respectent des axiomes fondamentaux (ex: lois de la physique), réduisant le besoin de données massives.
* **Le Raisonnement sur Latents :** Le système utilise un réseau de neurones pour traduire des données brutes (pixels) en symboles abstraits, qui sont ensuite traités par un moteur logique. Cela permet de conserver la puissance de perception tout en assurant la traçabilité de la décision finale.
### **3. Avantages Majeurs par rapport au Deep Learning**
L’approche NeSy répond aux impasses critiques des modèles purement statistiques (comme les LLM actuels) :
* **Explicabilité et Confiance :** Contrairement à une “boîte noire”, un système NeSy peut fournir une preuve logique de son raisonnement, ce qui est crucial pour les applications critiques (santé, défense).
* **Low-Shot Learning (Apprentissage économe) :** En s’appuyant sur des règles préétablies, l’IA peut apprendre avec très peu d’exemples, là où le Deep Learning nécessite des millions de données.
* **Réduction des Hallucinations :** Le composant symbolique agit comme un “garde-fou”, empêchant le système de générer des réponses qui violent la logique ou la causalité.
### **4. Exemples Concrets et Enjeux Stratégiques**
L’IA NeSy n’est plus théorique ; elle est déjà déployée dans des projets de pointe :
* **AlphaGeometry (Google DeepMind) :** Ce système a résolu des problèmes de géométrie de niveau olympique en utilisant un modèle de langage pour suggérer des constructions créatives (“l’intuition”) et un moteur symbolique pour en vérifier la validité mathématique (“la preuve”).
* **Programme ANSR (DARPA) :** L’armée américaine finance massivement cette recherche pour créer des IA “dignes de confiance par construction” (*trustworthy by design*), refusant de confier des systèmes d’armes autonomes à des algorithmes purement probabilistes.
* **Découverte de Médicaments :** Elle permet de modéliser des interactions moléculaires en combinant les prédictions statistiques avec des règles de chimie connues, réduisant les risques de toxicité imprévue.

En résumé, l’IA NeSy est la **condition *sine qua non* pour passer à la Quatrième Vague** (l’IA agentique et robotique) : sans la capacité de raisonner logiquement, une IA ne peut pas agir de manière sûre et autonome dans le monde physique.