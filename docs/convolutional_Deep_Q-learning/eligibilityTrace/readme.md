# **Q learning à N étapes (en anglais `Eligibility Trace`)**

Le principe de l’`Eligibility Trace` est que l’agent fait plusieurs étapes d’un coup. 
Ici, `N` vaut 4, donc c’est après les 4 étapes que l’agent va regarder la récompense totale obtenue. Et ainsi entrainer son réseau de neurones. C’est comme s’il combinait les quatre étapes en une.

## **Mais, est-ce que combiner les quatre étapes est une bonne idée ?**

On peut intuiter (pressentir) que le second va mieux se comporter, car le premier est guidé par la récompense sans vision d’ensemble. Alors que le second à un peu de recul, dans la mesure où il fait quatre étapes, puis observer la combinaison d’étapes afin de savoir si elle le guide vers la solution. Donc, il observe si la stratégie de combinaison est correcte ou non. L’agent s’intéresse à la récompense globale.

## **Pourquoi `Eligibility Trace`**

Après avoir obtenu la récompense cumulée de toutes les étapes effectuées, son algorithme, lui permet de se demander “quelle était l’étape à l’intérieur la plus éligible pour la récompense obtenue ?”  
Si l’agent reçoit une pénalité, il va observer quelle étape était responsable de l’attribution de la pénalité.

___
>>> cf.  
Le livre [Reinforcement Learning: An Introduction](https://mitpress.mit.edu/9780262039246/reinforcement-learning/) Richard S. SUTTON and Andrew G. BARTO (1998)  
[Reinforcement Learning: An Introduction ‘University of California - Berkeley’](https://inst.eecs.berkeley.edu/~cs188/sp20/assets/files/SuttonBartoIPRLBook2ndEd.pdf)  
[Asynchronous Methods for Deep Reinforcement Learning](https://mitpress.mit.edu/9780262039246/reinforcement-learning/) Volodymyr Mnih et al. (2016)