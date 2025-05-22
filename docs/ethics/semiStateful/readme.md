# **L’état semi-stateful**<a href="../"><img src="../../../assets/images/atomicAi.png" alt="Éthique de l'intelligence artificielle" align="right" height="64px"></a>
Ce terme n’est pas standardisé ni défini dans la littérature technique, contrairemnt à [“stateful”](../stateful) (avec état) et [“stateless”](../stateless) (sans état).  
Il est nonobsant parfois usité celon le contexte pour définir certaines applications ou composant conservant partiellement l’état (e.g. c’est une prétention de ChatGPT).

Seule une partie de l’état (un nombre limité de sessions) et/ou souvent temporairement conservée ou dans un contexte restreint. Cet état ne maintient pas l’intégralité de l’historique ou contexte.  
Cet état hybride est amnifester de plusierus façons :
* Le **stockage temporaire de l’état** :
  l’état est conservé durant une période ou pour une séquence limitée d’opération, puis oublié ou supprimé ;
* La **Gestion partielle du contexte** : 
  Seules les infos essentielles (tel qu’un id. de session ou jeton d’identification) sont retenues.

Le but est de facilité certains traitements et/ou d’améliorer la sécurité sans enregistrer l’intégralité de l’historique ou du contexte.  
Cette approche vise à combiner certains avantages des architectures stateful (e.g. la personnalisation, la sécurité, la continuité, …) & stateless (à savoir : l’évolutivité, la simplicité, la résiliance).

N’étant pas standardisé, sa définition varie selon les auteurs et contextes techniques.