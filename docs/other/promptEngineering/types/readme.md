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
À pour but de fournir un unique exemple de la réponse attendue (e.g. : Avec le plan de formation suivant (plan), écris le plan d’une formaition en dév Python).
#### **Le ’`Few Shot prompting`’**
À pout intérêt de fournir plusieurs exemples de ce qui est attendu.
### **Chain of Thoughts Prompting (pas à pas)**

### **Ask Before Prompting**

### **Perspective prompting (l’agent à un rôle)**

### **Comparative prompting**

## **Les prompts avancés**
___
>>> NOTA  
Le contenu doit toujours être anonymiser.
>>>
>>> Pour terminer un conversation avec un chatbot, il est possible de lui demande de ne plus en tenir compte et ne pas se contenter de la supprimer.