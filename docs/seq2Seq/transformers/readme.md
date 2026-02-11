# **Les réseaux de neurones Transformers**<a href="../../"><img src="../../../assets/images/atomicAi.png" alt="L'intelligence artificielle" align="right" height="64px"></a>
## **Définition**
Les Transformers sont , ou modèles "[séquence à séquence](../)", sont une technologie de réseau neuronal open source introduite par Google en 2017. Révolutionnaires pour le traitement du langage naturel, ils se sont depuis imposés comme une référence dans le domaine du traitement automatique du langage [(TAL) ou "natural language processing" (NLP)](../../other/tal).
## **Comment fonctionnent les réseaux de neurones Transformers**
Contrairement aux réseaux de neurones récurrents (RNN) qui traitent les séquences de données mot par mot, les Transformers exploitent un mécanisme d'attention ("attention mechanism"). Ce mécanisme permet au modèle de comprendre le contexte d'un mot ou d'une phrase en tenant compte de l'ensemble de la séquence.

## **Les différences avec les réseaux récurrents**
Avant Transformer, les modèles de traitement automatique du langage (TAL) s'appuyaient principalement sur des réseaux de neurones récurrents (RNN), comme les LSTMs et les GRUs. Ces modèles traitent les séquences élément par élément, en tenant compte de l'état caché des éléments précédents.

Cependant, les [RNN](../../rnn) souffrent de plusieurs limitations :

## **Quels sont les avantages**
* Une meilleure gestion des longues séquences   
  les Transformers ne souffrent pas du problème de disparition du gradient qui affecte les RNN.
* La parallélisation  
  l'architecture des Transformers permet un meilleur [parallélism](../../other/parallelization) du traitement, ce qui se traduit par une exécution plus rapide.
* La flexibilité  
  l'architecture des Transformers est flexible et peut être adaptée à une grande variété de tâches.
## **Les utilisations**
* Le traitement du langage naturel (TAL)  
  La traduction automatique, la génération de texte, le résumé de texte, la classification de texte, la réponse aux questions, etc.
* La vision par machine  
  La reconnaissance d'images, la génération d'images, etc.
* Et d'autres domaines tels que  
  La bio-informatique, la chimie, la finance, et cætera.

Google Translate, BERT signifiant Bidirectional Encoder Representations from Transformers, GPT-3 pour Generative Pre-trained Transformer 3, LaMDA qui signifie Language Model for Dialogue Applications ainsi que DALL-E en sont des exemples.

## **En conclusion**
Les réseaux de neurones Transformers ont révolutionné le domaine du traitement du langage naturel. Ils ont permis d'obtenir des résultats de pointe dans de nombreuses tâches et sont aujourd'hui l'un des types de réseaux de neurones les plus utilisés en TAL.  
Leur architecture flexible et leur capacité à gérer de longues séquences en font un outil puissant pour l'intelligence artificielle.