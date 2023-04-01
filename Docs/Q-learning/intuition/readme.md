<h1 align=center>Q-learning Intuition</h1>
<br>
<div align="center">
    <img src="https://github.com/MiKL5/artificialIntelligence/blob/master/Docs/img/BellmanCompleteEquation.png" alt="Équation de Bellman" title="Équation de Bellman">
</div>
<br>

## Pourquoi le Q-learning ?

Ici, l'agent ne regarde pas la valeur des états, mais la valeur de chaque action. Donc `Q` pour `Qualité` remplace `V` pour `Valeur`.  

Il y a un lien entre ces deux approches.  

Les `V`aleurs sont connues qui aides à calculer les `Q`ualités.  

> -> Ces deux approches sont différentes, bien qu'elles résolvent le même problème !  
Elles sont toutes les 2 valables et amènent au même résultat.  
Le raisonnement est un petit peu différent.  

<div align="center">
    <img src="https://github.com/MiKL5/artificialIntelligence/blob/master/Docs/img/Qlearning.jpg" alt="Équation" title="Équation">
</div>

___
>>> cf. :  
[Markov Decision Processes: Concepts ans Algorithms](https://www.semanticscholar.org/paper/Markov-Decision-Processes%3A-Concepts-and-Algorithms-Otterlo-Wiering/968bab782e52faf0f7957ca0f38b9e9078454afe?p2df)