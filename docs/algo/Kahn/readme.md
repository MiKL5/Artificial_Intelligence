# **L’algorithme de Kahn**
L’algorithme de Kahn est une méthode utilisée pour ordonner les sommets d’un graphe orienté acyclique (DAG) dans un ordre linéaire tel que pour chaque arête dirigée du sommet A vers le sommet B, A apparaisse avant B dans l’ordre.

## Les étapes
1. Trouver tous les sommets sans arête entrante (les sommets sources) et les ajouter dans un ensemble S.
2. Tant que l’ensemble S n’est pas vide :
    * Retirer un sommet n de S ;
    * Ajouter n à la liste L (qui contiendra l’ordre topologique) ;
    * Pour chaque sommet m avec une arête de n vers m :
        * Supprimer cette arête du graphe :
        * Si m n’a plus d’arête entrante, l’ajouter à S.
3. Si le graphe a encore des arêtes, cela signifie qu’il contient au moins un cycle, donc un tri topologique est impossible. Sinon, retourner la liste L qui contient l’ordre topologique.

Cet algorithme a une complexité en temps linéaire O(|V| + |E|), où |V| est le nombre de sommets et |E| le nombre d’arêtes du graphe.

L’algorithme de Kahn est l’un des deux principaux algorithmes pour effectuer un tri topologique, l’autre étant basé sur une recherche en profondeur (DFS).
## **Les variantes ou améliorations de cet algorithme**
1. L’algorithme de Kahn amélioré : Une variante de l’algorithme de Kahn consiste à maintenir une liste des sommets sans prédécesseur, plutôt que de les rechercher à chaque itération. Cela permet de réduire la complexité en temps de l’algorithme de O(|V| + |E|) à O(|E|).
2. L’algorithme de Tarjan : Cet algorithme utilise une approche basée sur la recherche en profondeur (DFS) pour trouver un tri topologique. Il est plus efficace que l’algorithme de Kahn dans certains cas, notamment lorsque le graphe est très dense. Sa complexité en temps est également en O(|V| + |E|).
3. L’algorithme de Kahn parallélisé : Des versions parallélisées de l’algorithme de Kahn ont été proposées, permettant d’exploiter le parallélisme pour accélérer le calcul du tri topologique, notamment sur des graphes de grande taille. Ces variantes ont une complexité en temps réduite par rapport à l’algorithme séquentiel.
4. L’algorithme de Kahn robuste aux erreurs : Certaines variantes de l’algorithme de Kahn ont été développées pour le rendre plus robuste aux erreurs, comme la présence de cycles dans le graphe. Ces versions modifiées peuvent détecter les cycles et fournir un résultat partiel ou signaler l’impossibilité d’obtenir un tri topologique.
5. L’algorithme de Kahn incrémental : Des versions incrémentales de l’algorithme de Kahn ont été proposées, permettant de mettre à jour le tri topologique lorsque le graphe est modifié (ajout ou suppression de sommets/arêtes), sans avoir à recalculer entièrement le tri. Cela peut être utile dans des applications où le graphe évolue dynamiquement.

_**⟹ Bien que l’algorithme de Kahn soit déjà efficace et largement utilisé, des variantes et améliorations ont été développées pour le rendre encore plus performant, notamment en termes de complexité temporelle, de parallélisation et de robustesse aux erreurs.**_
## **Les avantages et inconvénients**
<table>
    <tr>
        <th>Les avantages</th>
        <th>Les inconvénients</th>
    </tr>
        <td><b>La simplicité et facilité de compréhension</b><br>
    L'algorithme de Kahn est relativement simple à comprendre et à mettre en œuvre, ce qui le rend accessible aux développeurs et aux ingénieurs.</td>
        <td><b>La dépendance à la présence d'au moins un nœud sans prédécesseur</b><br>L'algorithme de Kahn nécessite que le graphe ait au moins un nœud avec un degré entrant (in-degree) nul, sans quoi il ne fonctionne pas correctement.<br>Cela peut être une limitation dans certains cas. </td>
    <tr>
        <td><b>La détection de cycles</b><br>En plus de trouver un tri topologique, l'algorithme de Kahn peut détecter la présence de cycles dans un graphe dirigé acyclique (DAG), ce qui est une fonctionnalité utile</td>
        <td><b>La possibilité de plusieurs tris topologiques</b><br>Bien que l'algorithme de Kahn garantisse de trouver un tri topologique, il peut en exister plusieurs pour un même graphe. Cela peut être une source de complexité dans certaines applications.</td>
    </tr>
    <tr>
        <td><b>L'efficacité algorithmique</b><br>L'algorithme de Kahn a une complexité en temps linéaire <code>(O(|V| + |E|))</code> et en espace linéaire, ce qui le rend efficace pour des applications pratiques impliquant de grands graphes.</td>
        <td><b>La sensibilité aux biais dans les données d'entrée</b><br>Comme tout algorithme d'apprentissage automatique, l'algorithme de Kahn peut être sensible aux biais présents dans les données d'entrée (le graphe), ce qui peut affecter l'équité des résultats dans certaines applications pratiques.</td>
    </tr>
</table>

## **Les principaux défis liés à l’équité algorithmique dans l’application pratique de l’algorithme de Kahn**
1. **La dfinitions incompatibles de l’équité algorithmique**  
   Il existe plusieurs définitions d’équité algorithmique qui peuvent être incompatibles les unes avec les autres.  
   Chaque définition interprète l’équité différemment, ce qui soulève des avantages et des inconvénients pour chacune d’entre elles.
2. **Les données d’apprentissage biaisées ou non représentatives**  
   Si les données utilisées pour entraîner l’algorithme de Kahn ne sont pas équilibrées et représentatives de la population cible, le modèle risque d’ignorer ou de négliger certains groupes, entraînant des disparités de performance.
3. **La difficulté d’obtenir des données objectives sur la “vérité terrain”**  
   Dans certains domaines, comme le comportement humain, il peut être difficile d’obtenir des données de haute qualité et objectives sur la variable cible à prédire. Cela peut conduire à utiliser des substituts moins fiables, introduisant des biais.
4. **Les limites inhérentes aux notions mathématiques de l’équité**  
   Les approches mathématiques de l’équité algorithmique peuvent avoir des limites intrinsèques, ne permettant pas toujours de capturer pleinement la complexité de l’équité éthique.
5. **Le manque de transparence et d’interprétabilité des modèles**  
   Les modèles d’apprentissage automatique comme l’algorithme de Kahn peuvent être opaques, rendant difficile l’explication et la traçabilité des décisions prises, ce qui nuit à l’équité.
6. **Le risque de biais statistiques dans les modèles prédictifs**  
   Les modèles prédictifs basés sur l’algorithme de Kahn peuvent introduire des biais statistiques, notamment en raison de la qualité et de la représentativité des données d’entraînement. Cela peut conduire à des décisions discriminatoires.
## **Comment peut-on améliorer la transparence et l’interprétabilité des modèles d’apprentissage automatique comme l’algorithme de Kahn ?**
1. **Utiliser des modèles plus simples et interprétables lorsque c’est possible**   
   Les modèles linéaires, les arbres de décision ou les forêts aléatoires sont généralement plus transparents et interprétables que les réseaux de neurones profonds.
2. **Expliquer les décisions du modèle**  
   Appliquer des techniques d’explication locale, comme `LIME` ou `SHAP`, qui permettent d’identifier les variables les plus importantes pour une prédiction donnée.  
   Cela aide à comprendre le raisonnement du modèle.
3. **Visualiser le fonctionnement du modèle**  
   Utiliser des techniques de visualisation, comme les graphiques de dépendance partielle, pour représenter l’impact des variables sur les prédictions du modèle.  
   Cela facilite la compréhension de son comportement global.
4. **Documenter le processus de développement du modèle**  
   Expliquer clairement les choix effectués lors de la sélection des données, de la conception de l’architecture du modèle et de son entraînement.  
   Afin de mieux comprendre les biais potentiels.
5. **Impliquer les parties prenantes dans le développement**  
   Collaborer avec les utilisateurs finaux, les experts du domaine et les décideurs pour s’assurer que le modèle répond à leurs besoins en termes de transparence et d’interprétabilité.
6. **Adopter des normes et des réglementations en matière de transparence des algorithmes**  
   Suivre les lignes directrices éthiques pour une IA digne de confiance, comme celles proposées par le Groupe d’experts européens.  
   Cela contribue à harmoniser les pratiques.