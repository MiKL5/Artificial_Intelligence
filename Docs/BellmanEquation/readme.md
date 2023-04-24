# **L’équation de Bellman**

## **Le concept** :

* s -> state (l'état de l'environnement) ;  
* a -> action (que peut prendre l'agent, dépendent généralement de l'état de l'environnement) ;  
* R -> reward (récompense qu'obtient l'agent pour entrer dans un état) ;
* γ (gamma) -> discount (réduction).


Richard Ernest BELLMAN est l'inventeur de l'équation est un mathématicien appliqué qui est à l'origine de la programmation dynamique, nommée aujourd'hui apprentissage par renforcement, c'est-à-dire l'équation de BELLMAN.  

Supposons que l'IA est dans un labyrinthe. La case feu fait perdre 1 point et la case arrivée fait gagner un point. Elle ne sait pas quoi faire et se déplace au hasard. Cependant, une fois arrivé, elle gagne un point et observe comment elle est arrivée en analysant le chemin inverse et accorde une valeur de 1 point (v=1) aux cases qui ont permis le chemin optimal et gagner le point de la case d'arrivée.  

## **L'équation** :

<div align="center">
    <img src="..\img\BellmanEquation.png" alt="Équation de Bellman" title="Équation de Bellman">
</div>

**`V(s)`** est la valeur de l'état.  
**`a`** est l'action qui amène à un nouvel état nommé **`s'`**.  
Pour chaque action possible est calculée 2 éléments :  
* **`r`** dépend de l'état actuel et de l'action accomplie (+1, -1 ou 0) ;  
* **`V`** valeur du nouvel état si l'action est prise.  

Alors, si on multiplie par **`γ`**[¹]  
**`max a`** va maximiser l'expression (récompense). Pour cela on prend l'action dans l'état + le gamma x la valeur du prochain état.    
**`S'`** est l'état dans lequel l'IA va arriver l'exécution d'une action.

___
[¹] Dans un labyrinthe, plus une case est proche de la solution plus elle a de la valeur. Donc, à chaque récompense, on a une valeur plus élevée et la valeur de prochain état multipliée par le facteur de réduction. Et l'agent réalise l'action qui a la valeur la plus élevée.  
Gamma **`γ`**, permet de quantifier la valeur d'une case par rapport à ça distance de l'arrivée.  
Ici, **`γ`** = 0,9.  
La case qui mène à l'arrivée vaut 1. Comme l'agent est sur une case blanche, on fait 0,9 x (la valeur de la prochaine case) 1 et obtient 0,81. Pour la précédente 0,9 x 0,81 = 0,73. Et 0,73 x 0,9 = 0,66.
___
>> NOTA :  
Le plan consiste à remplacer les valeurs par des flèches.
___
>> Cf.  
[The theory of dynamic programming](https://www.rand.org/content/dam/rand/pubs/papers/2008/P550.pdf)