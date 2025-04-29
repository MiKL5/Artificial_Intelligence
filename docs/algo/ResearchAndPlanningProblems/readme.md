# **Les problèmes de recherche et planification** <a href="../../../"><img src="../../../assets/images/ai1.png" alt="Les intelligences artificielles" align="right" height="64px"></a>
Il s’agit des voitures autonomes ainsi que l’IA pour jouer.  
Leurs but des de résoudre des problèmes similaires aux échecs ou la difficulté n’est pas tant de déplacer une pièce que de la protéger de l’adversaire.

Il y a souvent de nombreuses manières de résoudre un problème, certaines pouvant être préférables en termes de temps, d’effort, de coût voire d’autres critères. Différentes techniques de recherche peuvent aboutir à des solutions différentes et la mise au point d’algorithmes de recherche avancés est un domaine de recherche bien établi.

La définition des choix et leurs conséquences est souvent loin d’être anodin et mérite une réflexion approfondie. il faut aussi définir l’objectif ou, en d’autres termes, à quel moment le problème sera considéré résolu. Puis, rechercher une séquence d’actions qui nous mènera de l’état initial jusqu’à l’objectif.

Deux types de problèmes seront abordés :
* La recherche et la planification en milieu statique, avec un seul «agent» ;
* Les jeux à deux joueurs («agents») en concurrence.

Ces catégories ne couvrent pas tous les scénarios possibles en conditions réelles, mais sont suffisamment génériques pour illustrer les principaux concepts et techniques.
## **Terminologie clé**
### **L’espace d’état**
Est l’ensemble des situations possibles.  
Si la tâche consiste à passer de l’endroit A à B, l’espace d’état pourrait être constitué par les endroits définis par leur coordonnées (x , y) susceptibles d’être atteints depuis le point de départ. Pourtant, il est possible d’utiliser un ensemble restreint d’endroits (e.g. différentes adresses) de sorte que le nombre d’états possibles soit limités
### **Les transitions**
Sont les déplacements possibles entre deux états. 
Il est important de retenir que seules les transitions directes accomplissable en une action entre chaque transition sont comptabilisées.  
C’est-à-dire qu’une séquence multiple de transition multiple (E.g. `A à C`, de `C à D`, puis de `D à B`) est l’objectif, donc un chemin, pas une transition.
### **Les coûts**
Désignent que, souvent, les transitions ne sont pas identiques. Elles peuvent varier de façon à rendre certaines préférables donc moins coûteuses (parfois pas monétairement). Cela peut être exprimer en associant un certain coût à chaque transition.  
Si l’objectif est de réduire au minimum la distance totale parcourue, la distance géographique entre les états est un coût naturel. D’autre part, l’objectif pourrait être de réduire au minimum le temps plutôt que la distance, là, le coût naturel serait le temps. Si toutes les transitions sont égales, les coûts peuvent être ignorés.