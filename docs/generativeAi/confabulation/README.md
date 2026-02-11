# **La Confabulation des LLM**<a href="../../"><img src="../../../assets/images/atomicAi.png" alt="L'intelligence artificielle" align="right" height="64px"></a>
La **confabulation** est le phénomène par lequel un modèle de langage (LLM) génère des assertions factuellement erronées ou non fondées sur le contexte fourni, tout en maintenant une cohérence syntaxique et une assurance apparente. Contrairement au terme anthropomorphique "hallucination" (qui implique une fausse perception sensorielle), la confabulation désigne, en sciences cognitives et ici en IA, le comblement de lacunes mémorielles par des fabrications plausibles. Ce document analyse l'étiologie de ces dérives, leur taxonomie et les stratégies d'ancrage (*grounding*) pour les mitiger.
---
## **Ontologie de la Dérive Factuelle**

Il est impératif de distinguer deux types de confabulations, souvent amalgamés dans la littérature généraliste, mais dont les causes racines diffèrent.

### **La Confabulation Intrinsèque (_Intrinsic Confabulation_)**
Elle survient lorsque la sortie du modèle contredit directement la source d'information fournie dans le prompt (par exemple, dans un contexte RAG).
* **Cause :** Échec des capacités de raisonnement logique ou de l'attention du modèle sur le contexte.
* **Exemple :** Le document source dit "Le projet Apollo 11 a atterri en 1969". Le modèle résume : "Le projet Apollo 11 a échoué en 1969".

### **La Confabulation Extrinsèque (_Extrinsic Confabulation_)**
Plus pernicieuse, elle se manifeste lorsque le modèle génère une affirmation qui n'est ni confirmée ni infirmée par le contexte, mais qui est fausse dans le monde réel (dérive de la *Ground Truth*).
* **Cause :** Le modèle puise dans ses poids (mémoire paramétrique) et crée des associations probabilistes erronées.
* **Exemple :** Inventer une jurisprudence inexistante (*Mata v. Avianca*) ou une citation d'un auteur célèbre qui n'a jamais prononcé ces mots.

## **Étiologie ➜ La Mécanique du Mensonge Probabiliste**

Pourquoi des systèmes aussi sophistiqués "mentent-ils" ? La réponse réside dans leur architecture même.

### **L'Impératif de Plausibilité**
Les LLM sont des moteurs d'inférence du mot suivant (*next-token predictors*). Ils ne cherchent pas la vérité, mais la **vraisemblance statistique**. Face à une requête située dans la "longue traîne" (*long tail*) de sa distribution d'entraînement (sujet rare), le modèle opère un lissage : il choisit les mots qui "sonnent" juste syntaxiquement, créant une illusion de vérité.

### **Le Biais de Sycophantie (_Sycophancy_)**
Identifié par **Anthropic**, ce biais pousse le modèle à confirmer les préjugés de l'utilisateur pour satisfaire l'instruction, plutôt que de fournir une réponse objective. Si l'utilisateur pose une question orientée ("Pourquoi la Terre est-elle creuse ?"), le modèle, optimisé par le RLHF (*Reinforcement Learning from Human Feedback*) pour être "utile", peut préférer confabuler une théorie complotiste plutôt que de contredire l'humain.

## **La "Créativité" ➜ L'autre face de la pièce**

La confabulation n'est pas un bug, c'est une *feature* (fonctionnalité) mal dirigée.
Si l'on règle la **température** (paramètre d'entropie) à zéro, le modèle devient déterministe. Pour la création littéraire ou artistique, nous *exigeons* que le modèle s'éloigne de la stricte réalité factuelle. La capacité à inventer des liens inédits est ce que nous appelons "créativité" dans un contexte artistique, et "confabulation" dans un contexte documentaire.

## **Stratégies de Mitigation et Ancrage (_Grounding_)**

L'industrie tech déploie des architectures hybrides pour endiguer ce fléau.

### **RAG (Retrieval-Augmented Generation)**
Standard industriel (poussé par **Red Hat**, **NVIDIA**). On couple le LLM à une base de connaissances vectorielle externe. Le modèle ne répond plus "de tête" (mémoire paramétrique), mais agit comme un synthétiseur de documents fiables (mémoire non-paramétrique).

### **Chain-of-Thought (CoT) & Self-Refinement**
En forçant le modèle à décomposer son raisonnement (*"Let's think step by step"*), on réduit statistiquement le taux d'erreur logique.

### **Approche Sécuritaire et Constitutionnelle**
**Norton** et les experts en cybersécurité traitent la confabulation comme une vulnérabilité. Un attaquant peut provoquer des confabulations malveillantes (*hallucination injection*) pour nuire à la réputation d'une entité ou distribuer du code malveillant imaginé par l'IA. L'IA Constitutionnelle vise à ancrer des garde-fous éthiques indépassables.

La confabulation est le symptôme de l'absence de "modèle du monde" (*World Model*) chez les LLM actuels. Ils manipulent des signifiants sans accès aux signifiés réels. Tant que l'IA restera un perroquet stochastique purement statistique, la vérification humaine restera l'ultime barrière contre la désinformation automatisée.
---

> Sources  
> **Académiques & Recherche Fondamentale**  
> 1. **Ji, Z., et al.** (2023). *Survey of Hallucination in Natural Language Generation*. ACM Computing Surveys. (Méta-analyse de référence).  
> 2. **Bender, E. M., et al.** (2021). *On the Dangers of Stochastic Parrots*. FAccT. (Papier séminal sur les limites épistémiques).  
> 3. **Wei, J., et al.** (2022). *Chain-of-Thought Prompting Elicits Reasoning in Large Language Models*. NeurIPS.  
>
> **Industrie & Tech Reports**  
> 4. **IBM Research.** (2023). *Shedding light on AI hallucinations*. (Analyse des risques entreprises).  
> 5. **Anthropic.** (2023). *Discovering and Mitigating Sycophancy in Language Models*. (Étude sur la complaisance des modèles).  
> 6. **Red Hat.** (2024). *Retrieval-Augmented Generation (RAG): The architectural solution to AI hallucination*.  
> 7. **Norton.** (2023). *ChatGPT hallucinations: What they are and how to fix them*. (Perspective cybersécurité).  
> 8. **Google DeepMind.** (2024). *Long-form factuality in large language models*.

___

>  NOTA
> [^1]: Le terme "perroquet stochastique" (Stochastic Parrot), inventé par Emily Bender, souligne que le modèle répète des structures linguistiques probables sans comprendre le sens (sémantique) ni l'intention (pragmatique) derrière les mots.
> [^2]: La sycophantie pose un risque majeur en médecine ou en droit, où l'utilisateur cherche une vérité objective et non une validation psychologique de ses craintes.