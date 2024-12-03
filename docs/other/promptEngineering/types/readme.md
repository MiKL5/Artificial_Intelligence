# **Les principaux types de prompts** <a href="../"><img src="https://github.com/MiKL5/BI/raw/master/assets/bi.svg" alt="Les intelligences artificielles" align="right" height="64px"></a></h1>

## Les prompts basiques
Apportent une réponse simple, pour la classification de texte ou répondre à des questions simples.  
Faciles à créer et comprendre pour les débutants.  
Ces prompts ne sont pas aussi précis, ni personnalisés.  
Ils permettent :
* D’expliquer ;
* Lister ;
* Résumer ;
* Créer ;
* Structurer et planifier ;
* Transformer et traduire.

⟹ Ne considèrent pas la subtilité.  
Tout cela reste basique.

D’où la limite fréquente des réponses imprécises et l’intérêt du Prompt Primming.
## **Prompt Primming (l’amorçage)**
Ayant pour but de guider l’IA à répondre plus personnellement et plus cohéremment, ça consiste à fournir un contexte au modèle avant l’inférence d’une réponse.  
Le premier principe du prompt engineering est la clarté. Donc préciser au chatbot ce dont j’ai besoin.

L’ajout d’étape, la demande de tableau, le tri permettent d’affiner.
## **Les prompts intermédiaires**
### **Shot Prompting (0, 1, 2, 3)**
C’est un terme général désignant les façons de donner des instruction aux modèles d’IA.  
Il y a trois sortes de ’`Shot prompting`’ :
#### **Le ’`Zero shot`’**
Consiste à demander la complétion d’une phrase ou question sans exemple ni contexte.
#### **Le ’`One shot`’**
À pour but de fournir un unique exemple de la réponse attendue (e.g. : Avec le plan de formation suivant (plan), écris le plan d’une formation en dév Python).
#### **Le ’`Few Shot prompting`’**
À pout intérêt de fournir plusieurs exemples de ce qui est attendu (e.g. convertir les chiffres arabes en chiffres romains).
### **Chain of Thoughts Prompting (pas à pas)**
Cette méthode consiste demander au modèle de produire des étapes de raisonnement intermédiaires avant de donner la réponse finale à un problème complexe. Le but<!--final--> est que le modèle génère une chaîne de pensée imitant un processus de réflexion intuitif lors de la résolution du problème nécessitant plusieurs étapes.

’`Chain of Thoughts`’ est une technique de psychothérapie pour aider les patients à expliquer clairement leurs pensées et approfondir leurs sentiments.
<!--Je peux demander 'Fais ça est explique chaque étapes (ou pas-à-pas)'-->
### **Ask Before Prompting**
Ça consiste à demander à l’IA si tout est parfaitement compris et si cet agent à besoin de précision avant de répondre.  
Ainsi le modèle est aussi précis que possible en s’assurant que la demande est correctement comprise. Ceci est proche d’une méthode éducative avant que l’exercice débute.

Donc demander à l’IA ce que l’on attend en l’invitant à questionner si besoin.
### **Perspective prompting (l’agent à un rôle)**
En français, prompting selon un point de vue.  
Cela consiste à demander à l’agent d’agir selon un point de vue ou un rôle afin d’obtenir une réponse plus précise et pointue.

Le point de vue d’un adolescent ou expert de la Science des données apportent des réponses absolument différentes.

Il est possible de multiplier les points de vue en interagissant en groupe de personnes.
<!--Écris un texte sur le réchauffement climatique du point de vue de quatre personnes, en incluant leur nom et point de vue. Le premier est experte climatologue, la seconde est climatosceptique, la troisième est agriculteur et la dernière un écologiste-->
### **Comparative prompting**
Son but est de comparer plusieurs éléments (objets, concepts, personnes ou autre). Et mettre en valeur les forces et faiblisses ou les similitudes et différences.  
Les mots clés sont compare, définis les forces et faiblesses, différencie, les avantages et les inconvénients, …
## **Les prompts avancés**
Ces techniques servent à optimiser les performances et la fiabilité des modèles de langages pour des tâches plus spécifiques ou plus complexes. Elles sont surtout utiles avec des LLM(e.g. ChatGPT, Gemini, et cætera).
### **Le P. R. O. M. P. T.**
Ces techniques servent à optimiser les performances et la fiabilité des modèles de langages pour des tâches plus spécifiques ou plus complexes. Elles sont surtout utiles avec des LLM(e.g. ChatGPT, Gemini, et cætera).
1. Personnification de l’IA (persona).  
   Lui donner une personnalité (un rôle) ;
2. Résultat attendu (result).  
   Le résultat attendu ;
3. Objectif de la tâche (goal).  
   La raison attendue.
4. Mise en situation de l’IA (scenario).  
   E.g. « Tu es dans le Digital Marketing. » ;
5. Pour qui et pourquoi ? (context).  
   Qui est dans le contexte et pourquoi ? E.g. Contenu destiné à une audience de 18 à 34 an passionnée par l’AIOT.
6. Trame à suivre (Ton).  
   Le fil conducteur et les limitations (taille du texte, créer un tableau, le résultat doit … et en doit pas …).
#### **I want to act as… (Je veux agir comme)**
Demande au modèle un comportement comme un rôle défini afin de guider le modèle à des sorties plus spécifiques et pertinentes au contexte ou à la tâche souhaitée.  
Puis interagir et ordonner les actions.  
Il y a aussi 6 étapes :
1.	I want to you act?  
    (Agis comme ou comporte toi comme);
2.	Interaction avec l ’agent  
    (Je suis … Je te donne … La ville est) ;
3.	Définition de la tâche  
    (Traduit. Liste 10 musées à Paris, Tu dois …) ;
4.	Explication de la réponse voulue  
    (Le style ou format demander. Informel. Comme un enfant. Dans un tableau, une liste numérotée, à puce …) ;
5.	Définition des points importants  
    (Le contenu doit. Les catégories sont …) ;
6.	La première tâche  
    (Le première vile est … Commence par … La tâche est …).
___
>>> NOTA  
Le contenu doit toujours être anonymiser.
>>>
>>> Pour terminer une conversation avec un chatbot, il est possible de lui demande de ne plus en tenir compte et ne pas se contenter de la supprimer.
>>>
>>>[Maîtriser la structure des invites](https://medium.com/@tomskiecke/mastering-prompt-structure-for-chatgpt-4o-success-5fc84735809f)