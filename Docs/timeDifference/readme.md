# Différence temporelle

Le calcul de la valeur d'un état est plus compliquée dans le cas stochastique, car il faut connaître la valeur des cases adjacentes de lesquelles l'agent pourrait aller. Et pour connaître la valeur des cases adjacente, il faut connaître celle de la case originelle.  
C'est pour ça que l'agent a besoin de la différence temporelle.  

La différence temporelle est basée sur la qualité de prendre l'action dans l'état.

<div align="center">
    <img src="https://github.com/MiKL5/artificialIntelligence/blob/master/Docs/img/equationQlearningComplete.png" alt="Équation de Bellman réellement utilisée par l'IA" title="Équation de Bellman réellement utilisée par l'IA">
</div>

