# **L'IAoT : La Convergence Synergique de l'Intelligence Artificielle et de l'Internet des Objets**<a href="../../"><img src="../../../assets/images/atomicAi.png" alt="L'intelligence artificielle" align="right" height="64px"></a>
## **De la Télémétrie à la Cognition Distribuée**
L'Internet des Objets (IoT) est conçu comme un réseau de transducteurs (capteurs et actionneurs) dont la finalité était la collecte massive de données (*Big Data*) pour un traitement centralisé. L'IAoT représente une rupture épistémologique et technique : doter les nœuds périphériques de capacités d'inférence, transformant ainsi l'objet connecté en un agent autonome capable de décisions locales.

Cette fusion répond à quatre impératifs critiques :
1.  **Latence** ➜ La nécessité d'un temps de réponse déterministe (ex: véhicule autonome).
2.  **Bande passante** ➜ La saturation des réseaux par l'envoi de données brutes.
3.  **Confidentialité** ➜ Le maintien des données sensibles en local (*Privacy Preserving*).
4.  **Résilience** ➜ La continuité de service en cas de rupture de connexion au Cloud.
## **Architecture et Topologie de Traitement**
L'IAoT ne supprime pas le Cloud, elle redéfinit la répartition de la charge computationnelle selon un continuum *Edge-Fog-Cloud*.
### **1. Edge AI (L'IA à la périphérie)**
Il s'agit de l'exécution d'algorithmes d'apprentissage automatique (ML) directement sur le dispositif (MCU, DSP, FPGA).
* **Contraintes** ➜ Budget énergétique limité (mW), mémoire contrainte<!-- (SRAM < 512 Ko)-->.
* **Technologie clé** ➜ **TinyML**. Ce sous-domaine vise à compresser les réseaux de neurones (quantification, *pruning*) pour qu'ils s'exécutent sur des microcontrôleurs (ex: ARM Cortex-M).
### **2. Fog Computing (L'informatique en brouillard)**
Introduit par Cisco, ce niveau intermédiaire (passerelles, routeurs industriels) agrège les données locales pour des inférences plus complexes que celles du *Edge*, mais moins latentes que celles du *Cloud*. Il permet une intelligence en essaim (*Swarm Intelligence*).
## **Matériel et Accélération Neuromorphique**
L'exécution de réseaux de neurones convolutifs (CNN) ou récurrents (RNN) sur des architectures de Von Neumann classiques est inefficace énergétiquement. L'IAoT favorise l'émergence de processeurs spécialisés :
* **NPU (Neural Processing Units) :** Accélérateurs matriciels intégrés aux SoC.
* **Puces Neuromorphiques :** Architectures inspirées de la biologie (ex: Spiking Neural Networks - SNN), où le traitement est asynchrone et événementiel, réduisant drastiquement la consommation (ex: Intel Loihi).
## **Protocoles et Connectivité**
L'intelligence distribuée requiert des protocoles de communication adaptés à la contrainte et à la densité :
* **LPWAN (Low Power Wide Area Network) :** LoRaWAN, Sigfox, NB-IoT pour la longue portée et le bas débit.
* **5G / 6G :** Crucial pour l'URLLC (*Ultra-Reliable Low Latency Communications*) permettant le pilotage critique en temps réel.
## **Éthique, Sécurité et Droit (RGPD & AI Act)**
L'intégration de l'IA dans les objets du quotidien soulève des défis juridiques majeurs que l'ingénieur doit intégrer *by design*.
### **1. Minimisation des données (RGPD Art. 5)**
L'IAoT permet de respecter le principe de minimisation en traitant la donnée (ex: une vidéo) localement et en n'envoyant que le résultat (ex: "intrusion détectée"), on évite le transfert de données biométriques vers le Cloud, réduisant la surface d'attaque et l'exposition juridique.
### **2. Sécurité des modèles**
Les dispositifs Edge sont physiquement accessibles, les exposant à ces attaques
* **Adversarial Attacks** ➜ Perturbation des entrées capteurs pour tromper le modèle.
* **Model Inversion** ➜ Rétro-ingénierie du modèle pour extraire les données d'entraînement.
> **Note Impérative** ➜ Tout déploiement IAoT en Europe doit se conformer à l'*AI Act* (Règlement sur l'IA), classifiant les usages selon le niveau de risque.
## **Cas d'Usage Avancés**
* **Maintenance Prédictive (Industrie 4.0)** ➜ Analyse vibratoire temps réel sur les moteurs via TinyML pour prédire les pannes sans latence.
* **Santé Connectée (IoMT)** ➜ Analyse de l'ECG en local sur un *wearable* pour détecter l'arythmie et alerter uniquement en cas d'anomalie avérée.
___
> **Sources**
> 1. **Zhang, D., et al.** (2020). *Edge Intelligence: Paving the Last Mile of Artificial Intelligence With Edge Computing*. Proceedings of the IEEE, 107(8), 1738-1762.
> 2. **Warden, P., & Situnayake, D.** (2019). *TinyML: Machine Learning with TensorFlow Lite on Arduino and Ultra-Low-Power Microcontrollers*. O'Reilly Media.
> 3. **Union Européenne.** (2016). *Règlement (UE) 2016/679 (RGPD)*.
> 4. **Hanes, D., et al.** (2017). *IoT Fundamentals: Networking Technologies, Protocols, and Use Cases for the Internet of Things*. Cisco Press.
> 5. **Lecun, Y., Bengio, Y., & Hinton, G.** (2015). *Deep learning*. Nature, 521(7553), 436-444. (Fondamental pour la partie algorithmique).