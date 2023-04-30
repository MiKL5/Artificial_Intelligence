# L'algorithme du gradant stochastique

Le défaut de le [précécente méthode](../gradientAlgorithm) est qu'elle n'est pas convexe comme l'oeil.

La fonction de coût n'est jamais une courbe parfaite (convexe). Dans la pratique, elle peut monter et descendre à pluseieurs endroits.  
L'agent peut tomber sur un minimum local mais pas global (le meilleur).  

L'algorithme du gradient stochastiqu s'affranchi de l'hypothèse du convexoté. 