# **Pénalité de vie**<a href="../"><img src="../../assets/images/atomicAi.png" alt="L'intelligence artificielle" align="right" height="64px"></a>
<br>
<div align="center">
    <img src="../../assets/images/4doc/BellmanCompleteEquation.png" alt="Équation de Bellman" title="Équation de Bellman">
</div>
<br>

Dans la réalité, l’agent est récompensé au fur et à mesure de son avancée dans l’environnement.  

Afin de l’inciter à résoudre plus vite le casse-tête, chaque état à une récompense négative :
* À chaque fois que l’agent bouge, il est récompensé ;  
* Plus il reste dans le labyrinthe, plus il accumule les pénalités.  
* Plus la pénalité est élevée, plus vite l’agent va sortir.  

<h3 style="color:#d20800">Cala influence évidement les décisions plus un moins critiques ; <b>une pénalité trop forte pousse à finir plus vite et a prendre les pires décisions</b>.</h3>