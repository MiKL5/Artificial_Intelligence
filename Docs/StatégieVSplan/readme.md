# Stratégie vs Plan
<br>
<h2 align="center">L'IA est très stochastique.<br>Maintenant, il s'agit de prendre en compte tout les favcteurs aléatoires (non maîtrisables).<h2>

<br>

>> ## Commonitorium 
<div align="center">
    <img src="..\img\BellmanCompleteEquation.png" alt="Équation de Bellman" title="Équation de Bellman">
</div>

> * `V de s` correspond à la valeur de la case où l'IA se situe actuellement, donc, la valeur de l’état dans lequel elle se situe présentement.  
> * Cette valeur est égale au maximum de toutes les actions possibles sur petit a `max a`, et donc il y a d'abord,  
>   * `R(s,a)` R, de s et de a : la récompense pour prendre une action `a` dans l'état `s` 
>   *  `+` `γ` qui est le facteur correcteur x la somme de tous les états `s'` dans lesquels l'IA peut atterrir
>   * `x` `V(s')` la probabilité (valeur) sur laquelles l'IA va se trouvée.
## 


