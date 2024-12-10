# **Comment fonctionne une AI générative conversationnelle ?**
## **Les mécanismes d’apprentissage**
L’apprentissage profond discipline de l’apprentissage automatique est le mécanisme de base afin de comprendre les problèmes qu’on adresse et générer les réponses textuelles. C’est un modèle pré-entraîner car avant la mise sur le marché, un très grand corpus textuel lui a permis de comprendre les nuances d’un langage humain et formuler des réponses contextualisées.

Pour comprendre, l’IA utilise la technique du langage naturel (Natural Language processing) pour décomposer la demande en phrase, puis en mot afin de saisir le contexte général, ainsi apporter une réponse la plus adaptée possible.

La technologie du [neurone Transformer (structure propre à l’apprentissage profond](../../seq2Seq/transformers) ; c’est-à-dire un réseau de neurones artificielles). Ces transformateurs, utilisent l’attention sélective. L’agent se focalise sur certains mots, l’ordre des mots, et la relation en ces derniers pour en déduire le contexte général et le contenu. Il découpe les mots en token.
1. Identifier le sujet (à donc une importance capitale) ;
2. Tenir comptes des informations de contexte (dans la cuisine), pour localiser l’action ;
3. Formuler sa réponse.

L’IA a également subie un entrainement par renforcement et des humains corriges les réponses, ce qui permet un apprentissage dynamique.
## **Comment ChatGPT génère les réponses ?**
Le modèle prédictif joue un rôle essentiel dans la construction des réponses.  
Les réponses sont générées selon une probabilité, tenant compte du mot le plus probables tout en considérant la façon dont les mots s’intègrent dans une phrase. Donc le but est d’anticipé la suie la plus logique.

Le modèle apprend des schémas et des associations dans les données d’entrainement pour apprendre à choisir à la suite les mots probables et répondre en fonction du contexte.
## **L’interaction entre le modèle d’IA et l’utilisateur**
L’utilisateur pause son souci,  
L’IA analyse le prompt, regarde la donnée et consulter l’enchaînement et donner la réponse la plus probable. Le contenu définitif.