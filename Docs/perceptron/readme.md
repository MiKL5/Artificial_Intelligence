# **Neurone formel**

Le [perceptron](https://fr.wikipedia.org/wiki/Perceptron "neurone formel"), encore appelé neurone artificiel ou neurone formel, sert à reproduire le fonctionnement d'un neurone biologique. Il existe différents niveaux d'abstraction, suivant la précision de la modélisation voulue.

Considérons les entités suivantes :  
•	des `entrées`, notées `x` sous formes de vecteurs, représentant les `dendrites` ;  
•	une `sortie`, notée `y`, représentant l'`axone` ;  
•	des `paramètres`, notés w et b, influençant le fonctionnement du neurone.  

Les entrées sont variables. Les paramètres sont fixés par construction du modèle. La sortie est calculée en fonction des entrées et des paramètres.

### Équation d'un neurone formel :
`y^=f(⟨w,x⟩+b)`

Chaque entrée est multipliée par un poids, un coefficient w.
Toutes les entrées sont alors sommées et additionnées à un biais b.
Le résultat de la somme passe à travers une fonction de transfert f (le plus souvent non linéaire). Cette fonction produit alors la sortie voulue.

Plus les entrées sont grandes en valeur absolue, plus la somme peut être grande en valeur absolue. Nous sommes donc en modulation d'amplitude (et non plus de fréquence, comme dans un neurone biologique).

### Apprentissage par descente de gradient

L'apprentissage d'un neurone se fait par optimisation d'une fonction de perte. C'est-à-dire que l'on va chercher les paramètres w et b, qui minimisent la fonction de perte. Dans le cas de la classification, on va utiliser la log-vraisemblance négative.

Quand tout est dérivable, on peut utiliser la descente de gradient.

À chaque étape, les paramètres sont déplacés.
