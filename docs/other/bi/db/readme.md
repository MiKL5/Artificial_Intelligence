# **Les bases de données en SQL, T-SQL et PL/SQL font partie de la business intelligence** <a href="../"><img src="https://github.com/MiKL5/BI/assets/bi.svg" alt="Business intelligence" align="right" height="64px"></a>
Les bases de données et les langages de requête tels que le SQL, le T-SQL et le PL/SQL jouent un rôle crucial dans la Business Intelligence (BI) pour collecter, stocker, géer et analyser _les données_, qui _sont les fondements de la BI_. 
## **Comment ils s’intègrent ?**
### Le SQL (Structured Query Language)
Le SQL est le langage standard pour interroger et manipuler les bases de données relationnelles :
* **Interroger les données** : Extraire des données spécifiques des tables.
* **Manipuler les données** : Insérer, mettre à jour et supprimer.
* **Définir des structures de données** : Créer et modifier les schémas de base de données (tables, index, vues, etc.).
* **Gérer les permissions** : Contrôler l’accès aux données pour les utilisateurs.
### Le Transact-SQL
Le T-SQL est une extension de SQL développée par Microsoft, utilisée principalement avec SQL Server. Il ajoute des fonctionnalités supplémentaires :
* **La programmation procédurale**  
  Boucles, conditions, et gestion des erreurs.
* **La création de procédures stockées**  
  Blocs de code SQL réutilisables pour des tâches répétitives.
* **La gestion avancée des transactions**   
* Contrôle plus fin des transactions pour assurer la cohérence des données.
* **Fonctions définies par l’utilisateur**   
  Création de fonctions personnalisées pour des opérations spécifiques.
### Le PL/SQL (Procedural Language/SQL) est une extension de SQL développée par Oracle pour ses bases de données. Ce qui inclu :
* **La programmation procédurale**  
  Similarité avec T-SQL pour les boucles, les conditions, et la gestion des erreurs.
* **La création de procédures stockées et de packages**  
  Organisation et réutilisation du code.
* Les déclencheurs (triggers)  
  Exécution automatique de code en réponse à des événements spécifiques dans la base de données.
* **La gestion des transactions avancée**  
  Contrôle des transactions pour maintenir l’intégrité des données.
### Le rôle dans la Business Intelligence
* **Extraire les données**  
  Utilisation de SQL pour extraire des données brutes des systèmes de production ou des bases de données transactionnelles.
* **Transformer les données**  
  Utilisation de T-SQL ou PL/SQL pour transformer les données extraites en les nettoyant, les filtrant, et les agrégant selon les besoins analytiques.
* **Charger les données**  
  Chargement des données transformées dans des entrepôts de données (ETL - Extract, Transform, Load).
* **Création de rapports et tableaux de bord**  
  Interrogation des entrepôts de données pour générer des rapports et des visualisations via des outils de BI.

<br><div align="center">

**_Les bases de données SQL et les langages de requête  sont des composants essentiels de l’infrastructure BI.  
Car ils permettent de gérer efficacement les données qui sont ensuite analysées pour fournir des insights et soutenir la prise de décision stratégique dans les entreprises._**