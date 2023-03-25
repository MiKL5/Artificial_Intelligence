# Stratégie vs Plan
<br>
<h2 align="center" style="color:#3fe056">Le fonctionnement de l'IA est <strong>stochastique</strong>.<br>Maintenant, il s'agit de prendre en compte tout les favcteurs aléatoires (non maîtrisables).<h2>
<br>

>> ## Commonitorium 
<div align="center">
    <img src="..\img\BellmanCompleteEquation.png" alt="Équation de Bellman" title="Équation de Bellman">
</div>

> * `V de s` correspond à la valeur de la case où l'IA se situe actuellement, donc, la valeur de l’état dans lequel elle se situe présentement.  
> * Cette valeur est égale au maximum de toutes les actions possibles sur petit a `max a`, et donc il y a d'abord,  
>   * `R(s,a)` R, de s et de a : la récompense pour prendre une action `a` dans l'état `s` 
>   *  `+` `γ` qui est le facteur correcteur x la somme de tous les états `s'` dans lesquels l'IA peut atterrir
>   * `x` `V(s')` la probabilité (valeur) sur laquelle l'IA va se trouvée.
## Calculer les valeurs dans un environnement stochastique

Les valeurs sont forcément plus basses car il est possible de se trouvé en bas en allant à droite donc de ne pas aller à l'arrivée et ne pas obtenir la récompense, et si la case est proche d'une mauvaise case, sa valeur et forcément plus faible ; c'est pourquoi une case loin de l'arrivée peut avoir une valeur plus forte car elle est plus sécuritaire.  
Ainsi, l'IA doit préférer le chemin le plus long pour prendre le moins de risque possible.  

Si l'IA se trouve dans une case proche d'un risque, elle prendra logiquement la décision d'aller dans le sens opposé au danger. Si le danger est au-dessus de la case actuelle, elle visera le bas, même si c'est un mûr, car elle a 0% de possibilité d'aller dans la case dangereuse, environ 10% de se heurter au mur de droite, environ 80 % de se heurter à celui d'en bas et environ 10 % d'en sortir.