# **Différence temporelle**  

Le calcul de la valeur d'un état est plus compliquée dans le cas stochastique, car il faut connaître la valeur des cases adjacentes de lesquelles l'agent pourrait aller. Et pour connaître la valeur des cases adjacente, il faut connaître celle de la case originelle.  
C'est pour ça que l'agent a besoin de la différence temporelle.  

La différence temporelle est basée sur la qualité de prendre l'action dans l'état.

C'est la différence entre ce qu'il s'est passé le passé et le futur. C'est-à-dire les informations que l'on vient juste d'avoir.  
Idéalement, si l'agent avait déjà toutes les informations, la différence serait égale à zéro. Ce qui est impossible tant qu'elle n'est pas suffisament entraînée.

## **Comment utiliser la différence ?**  



___
<div align="center">
    <img src="https://github.com/MiKL5/artificialIntelligence/blob/master/Docs/img/equationQlearningComplete.png" alt="Équation de Bellman réellement utilisée par l'IA" title="Équation de Bellman réellement utilisée par l'IA">
</div>

