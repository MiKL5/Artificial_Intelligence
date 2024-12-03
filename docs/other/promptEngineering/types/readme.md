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

### **Comparative prompting**

## **Les prompts avancés**
___
>>> NOTA  
Le contenu doit toujours être anonymiser.
>>>
>>> Pour terminer une conversation avec un chatbot, il est possible de lui demande de ne plus en tenir compte et ne pas se contenter de la supprimer.