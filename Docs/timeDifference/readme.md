# **Différence temporelle**  

Le calcul de la valeur d'un état est plus compliqué dans le cas stochastique, car il faut connaître la valeur des cases adjacentes de lesquelles l'agent pourrait aller. Et pour connaître la valeur des cases adjacente, il faut connaître celle de la case originelle.  
C'est pour ça que l'agent a besoin de la différence temporelle.  

La différence temporelle est basée sur la qualité de prendre l'action dans l'état.

C'est la différence entre ce qu'il est accompli entre le passé et le futur. C'est-à-dire les informations que l'on vient juste d'avoir.  
Idéalement, si l'agent avait déjà toutes les informations, la différence serait égale à zéro. Ce qui est impossible tant qu'elle n'est pas suffisamment entraînée.

## **Comment utiliser la différence ?**  

<div align="center">
    <img src="https://github.com/MiKL5/artificialIntelligence/blob/master/Docs/img/timeDifference2.png" alt="Différence temporelle" title="Différence temporelle">
</div>

Dans l'équation la partie de gauche est la définition de la qualité de l'état et de l'action par l'équation de Bellman. Et à droite la qualité de l'état et de l'action. La différence entre les deux, c'est le temps. Avant est à droite et après à gauche. Le but est de voir s'il y a une différence entre les deux. Et s'il y a une différence, l'ancienne valeur aura moins d'importance et prendre en considération la nouvelle valeur qui a plus d'infos. L'ancienne valeur est gardée pour faire face à l'imprévu. L'agent multiplie par la valeur alpha (de 0 à 1) pour pondérer l'importance à chaque expérience. Si alpha est égale à O, l'agent n'apprend pas, et s'il est = 0, il apprend trop, mais prend en compte les nouvelles infos.  
Le but est de mettre à jour la valeur `Q` qualité jusqu'à converger à une valeur stable. Car si à l'ajout d'une nouvelle info la valeur ne change pas ; c'est la vraie valeur. L'agent à converger vers sa limite, ce qui n'est pas vrai quand l'environnement changer ; l'agent doit se réadapter et réitérer ces calculs.

___
https://link.springer.com/article/10.1007/BF00115009