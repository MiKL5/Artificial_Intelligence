# **L'Internet des objets**<a href="../../"><img src="../../../assets/images/atomicAi.png" alt="L'intelligence artificielle" align="right" height="64px"></a>
L'Internet des Objets (IoT) n'est pas une simple collection de périphériques connectés, mais un système cyber-physique complexe permettant l'interfaçage du monde numérique et du monde tangible.  
L'Intelligence Artificielle (IA) agit comme le catalyseur cognitif nécessaire pour transformer le *Big Data* généré par l'IoT en valeur décisionnelle (*Smart Data*), notamment à travers le concept de Jumeaux Numériques (*Digital Twins*).
---
## **Introduction ➜ Ontologie et Changement de Paradigme**
L'Internet des Objets (IoT) représente la troisième vague de l'évolution de l'Internet, succédant à l'Internet des documents (Web 1.0/2.0) et précédant l'Internet des compétences (IoS). Le terme, inventé par **Kevin Ashton** en 1999 au MIT, désigne une infrastructure mondiale pour la société de l'information, qui permet de disposer de services évolués en interconnectant des objets (physiques et virtuels) grâce aux technologies de l'information et de la communication interopérables existantes ou en évolution (**UIT-T Y.2060**).

Le changement de paradigme réside dans la transition d'une saisie de données humaine (ex: clavier) à une acquisition de données autonome par des **transducteurs** (capteurs/actionneurs), créant une continuité entre le réel et le digital.
## **Architecture Systémique et Protocoles**
L'hétérogénéité des dispositifs IoT impose une architecture robuste, généralement modélisée en quatre strates fonctionnelles.
### **Couche de Perception (The Sensing Layer)**
C'est l'interface physique. Elle comprend les capteurs (température, lidar, piézoélectrique) et les actionneurs.
* **Défis :** Miniaturisation (MEMS), autonomie énergétique (Energy Harvesting) et coût.
### **Couche Réseau (The Network Layer)**
Assure la transmission des données. Contrairement à l'internet classique (TCP/IP via Ethernet/Wi-Fi), l'IoT s'appuie souvent sur des réseaux LPWAN (*Low Power Wide Area Network*) ou maillés (*Mesh*) pour optimiser la consommation.
* **Protocoles de transport :** MQTT (*Message Queuing Telemetry Transport* - pub/sub léger), CoAP (*Constrained Application Protocol* - UDP), LoRaWAN.
* **Adressage :** L'IPv6 via 6LoWPAN est impératif face à l'épuisement des adresses IPv4, permettant à chaque grain de sable d'avoir une adresse IP théorique.
### **Couche de Traitement (Middleware/Processing)**
C'est ici que s'opère la fusion des données. Cette couche abstraite masque la complexité matérielle aux applications.
### **Couche Application**
L'interface utilisateur et la logique métier (Smart City, Smart Grid, Agriculture de précision).
## **La Convergence IoT-IA : De la Connexion à la Cognition**
L'IoT génère des données (*Volume, Vélocité, Variété*), mais l'IoT seul est "stupide". L'IA apporte la capacité d'analyse et de décision. Sans IA, l'IoT n'est qu'un système de télémétrie glorifié.
### **Le Cycle DIKW (Data-Information-Knowledge-Wisdom)**
L'alliance IoT-IA permet de remonter cette chaîne de valeur :
1. **Data (IoT) :** Le capteur relève "24°C".
2. **Information :** "Il fait 24°C dans la salle serveur, c'est +4°C par rapport à la normale".
3. **Knowledge (ML) :** "Cette hausse précède statistiquement une panne du système de refroidissement dans 85% des cas".
4. **Wisdom (AI Action) :** "Je déroute les calculs vers un autre nœud et j'ouvre un ticket de maintenance".
### **Les Jumeaux Numériques (*Digital Twins*)**
C'est l'apogée de la synergie IoT-IA. Un jumeau numérique est une réplique virtuelle dynamique d'un système physique (ex: un moteur d'avion).
* **Rôle de l'IoT :** Alimenter le jumeau en temps réel pour qu'il reflète l'état exact de l'objet physique.
* **Rôle de l'IA :** Simuler des scénarios futurs sur le jumeau (*What-if scenarios*) pour prédire l'usure ou optimiser les performances sans risquer l'actif physique.
## **Sécurité et Enjeux Sociétaux**
L'ubiquité de l'IoT étend la surface d'attaque de manière exponentielle. La sécurité ne peut être une réflexion après coup (*afterthought*).
* **Sécurité Cyber-Physique :** Une attaque sur l'IoT peut avoir des conséquences cinétiques (ex: arrêt cardiaque d'un pacemaker connecté, prise de contrôle d'un véhicule autonome).
* **Botnets :** L'insécurité des objets (mots de passe par défaut) permet la création d'armées de bots (ex: Mirai) pour des attaques DDoS massives.
* **Privacy :** L'omniprésence des capteurs pose la question de la surveillance de masse et du consentement, nécessitant une application stricte du *Privacy by Design*.
___
> **Bibliographie et Références**
> 1.  **Atzori, L., Iera, A., & Morabito, G.** (2010). *The Internet of Things: A survey*. Computer Networks, 54(15), 2787-2805. (L'article séminal définissant le champ académique).
> 2.  **Gubbi, J., Buyya, R., Marusic, S., & Palaniswami, M.** (2013). *Internet of Things (IoT): A vision, architectural elements, and future directions*. Future Generation Computer Systems, 29(7), 1645-1660.
> 3.  **Ashton, K.** (2009). *That ‘Internet of Things’ Thing*. RFID Journal, 22(7), 97-114. (Rétrospective par l'inventeur du terme).
> 4.  **Porter, M. E., & Heppelmann, J. E.** (2014). *How Smart, Connected Products Are Transforming Competition*. Harvard Business Review.
> 5.  **Grieves, M.** (2014). *Digital Twin: Manufacturing Excellence through Virtual Factory Replication*. White Paper.