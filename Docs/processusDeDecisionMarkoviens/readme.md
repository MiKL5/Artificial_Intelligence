# **Processus décisionnels Markoviens (MDP)**

## **Processus déterministe**

Principe qui donne 100 % de probabilité que l'agent aille vers le haut.

```
L'agent a la maîtrise totale de sa décision et sait quel résultat, il aura.  
S'il part en haut, il se retrouve en haut
```

## **Processus non déterministe (stochastique)**

Pour aller vers le haut, l'agent à 10 % de probabilité d'aller à gauche, autant d'aller à droite et 80 % vers le haut. Ceci représente mieux la réalité car il y a généralement des facteurs aléatoires qui vont influencer le résultat. C'est aussi plus complexe à étudier.

## **Processus de Markov**

Un _processus stochastique_ vérifie la _propriété de Markov_ si et seulement si la distribution conditionnelle de probabilité des états futurs, étant donnés l'état présent, ne dépend en fait que de l'état présent et non pas des états passées (ont dit qu'il y a absence de 'mémoire').  
Simplement, le futur ne dépend que du présent, pas du passé.

```
L'agent a le contrôle total de sa décision, mais pas du résultat.  
Il peut décider d'aller en haut, mais il peut tomber dans un volcan, se cogner dans un mur, aller en haut ou arriver.
```

## **Processus de décision Markovien (MDP)**

Un processus de décision Markovien (MDP) est un modèle stochastique où un agent prend des décisions et où les résultats de ses actions sont aléatoires. Les MDP's sont une extension des chaînes des Markov. Les différence et l'addition des actions choisies par l'agent et des récompenses gagnées par l'agent. S'il n'y a qu'une seule action à tirer dans chaque état et que les récompenses sont égales, les processus de décision markovien et une chaîne de Markov.

Simplement, il n'y a qu'une seule action à tirer dans chaque état et que les récompenses sont égales. On revient donc, sur une chaîne de Markov.  

```
L'agent na pas le contrôle total de sa décision.  
L'agent ne sait pas trop quoi faire et fait appel au processus de décision de Markov.
```
En résumer, il y a ici deux processus.
* Le processus de Markov, qui va décrire la manière dont l'environnement est construit.  
cf. 1er paragraphe (processus non déterministe) ;
* le processus de décision markovien qui décrit la manière dont l'agent prend une décision et comment il va trouver son chemin.

___
<div align="center">
    <img src="..\img\BellmanEquation.png" alt="Équation de Bellman" title="Équation de Bellman">
</div>

**`V`** est la valeur d'un état  
**`S`** est le state  
est égale  
**`max a`** maximum des actions pouvant être prises, pour l'**a**ction, la
**`R`** récompense de prendre cette action dans l'état dans lequel elle est + la valeur `γ` (la réduction, facteur correctif) de la case sur laquelle l'agent va atterrir.
_il y a maintenant une partie aléatoire_, parce que l'agent ne sait pas exactement dans quel état il va se trouver.  
Pour rappel, il y a un pourcentage de probabilité.  
Pour **`V(s')`** l'état prime **`s'`** a plusieurs états possibles, l'agent peut avoir ici S1 prime, s2 prime et s3 prime et parfois beaucoup plus de possibilités, donc 3 valeurs différentes (V(s1'), et cætera).  L'agent calcul donc la moyenne de ces 3 possibilités et va les pondérer par les probabilités. Il y a 80 % de probabilités d'aller sur la case du haut donc 0,8 x sa valeur. Et 10 % de probabilités d'aller à gauche donc 0,1 x la valeur de cette case. Idem pour la droite.  

Ce qui mène à l'équation complète.

<div align="center">
    <img src="..\img\BellmanCompleteEquation.png" alt="Équation de Bellman" title="Équation de Bellman">
</div>

On somme sur tous les exprimes (les états) dans lesquelles l'agent peut se retrouver. Et à l'intérieur on a le **`P`** (probabilité) qui dépend de **`s`**, de **`a`** et de **`s'`**, en claire la probabilité de se retrouver dans le nouvel état, quand on fait l'action, quand on est dans l'état actuel x la valeur de cette nouvelle case **`V(s')`**.  
C'est ainsi que l'agent essaye de résoudre pour prendre sa décision.  

___
>> cf. Survey of Appllication of Markov Decision Processing  
http://www.cs.uml.edu/ecg/uploads/AIfall14/MDPApplications3.pdf  
Ce sont des exemples d'utilisation des chaînes de Markov dans le réel.