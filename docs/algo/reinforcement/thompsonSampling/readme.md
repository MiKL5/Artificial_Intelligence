# **Thompson sampling (échantillonnage de Thompson)**<a href="../"><img src="../../assets/images/atomicAi.png" alt="L'intelligence artificielle" align="right" height="64px"></a>
L'échantillonnage de Thompson est une heuristique probabiliste fondamentale résolvant le dilemme "exploration-exploitation" dans le cadre des problèmes de bandits manchots (*Multi-Armed Bandits* - MAB). Bien que proposée dès 1933, elle fut longtemps négligée au profit d'approches fréquentistes comme UCB (*Upper Confidence Bound*). Elle connaît une résurgence majeure depuis les années 2010 grâce à sa performance empirique supérieure et à la démonstration tardive de ses bornes de regret théoriques. Ce document décortique son fondement bayésien, son algorithmique et ses garanties de convergence.
---
## **Intro ➜ Le Dilemme du Bandit**

Le problème du bandit manchot multi-bras modélise un agent face à $K$ machines à sous (ou "bras"). Chaque bras $k$ fournit une récompense tirée d'une distribution de probabilité inconnue d'espérance $\mu_k$. L'objectif de l'agent est de maximiser la somme des récompenses sur un horizon de temps $T$, ce qui revient à minimiser le **regret cumulé** $R_T$.

$$R_T = T\mu^* - \sum_{t=1}^{T} \mathbb{E}[r_t]$$

Où $\mu^* = \max_k \mu_k$ est l'espérance du meilleur bras optimal.

Pour minimiser ce regret, l'agent doit arbitrer entre :
1. **Exploitation ➜** Tirer le bras que l'on *croit* être le meilleur actuellement.
2. **Exploration ➜** Tirer des bras moins connus pour affiner l'estimation de leurs espérances.

Contrairement aux méthodes optimistes face à l'incertitude (comme UCB) qui utilisent des bornes déterministes, l'échantillonnage de Thompson adopte une approche **bayésienne stochastique**.

## **Fondements Théoriques ➜ L'Approche Bayésienne**

Le principe cœur du Thompson Sampling (TS) est le **Probability Matching** : la probabilité qu'un agent choisisse une action $k$ doit être égale à la probabilité que cette action soit effectivement l'action optimale, conditionnée par l'historique des observations.

### **Le Mécanisme**

L'algorithme maintient une distribution *a posteriori* (posterior) sur les paramètres de récompense de chaque bras. À chaque étape $t$ :

1.  Pour chaque bras $k$, on échantillonne (tire au hasard) une valeur $\theta_k$ depuis sa distribution *a posteriori*.
2.  On joue le bras $k^*$ qui a produit la plus grande valeur échantillonnée : $k^* = \arg\max_k \theta_k$.
3.  On observe la récompense réelle $r_t$ et on met à jour la distribution *a posteriori* du bras joué selon la règle de Bayes.

### **Le Cas Beta-Bernoulli (Canonique)**

C'est l'implémentation la plus courante (ex: taux de clic publicitaire ou conversion web).

* **Vraisemblance (Likelihood) ➜** Les récompenses sont binaires $r \in \{0, 1\}$ suivant une loi de Bernoulli.
* **A priori (Prior) ➜** On utilise la loi Bêta, conjuguée de la loi de Bernoulli.

Soit $\alpha_k$ le nombre de succès (récompenses = 1) et $\beta_k$ le nombre d'échecs (récompenses = 0) pour le bras $k$. La distribution de la probabilité de succès moyenne $\theta_k$ est :

$$P(\theta_k | \mathcal{D}_t) \sim \text{Beta}(\alpha_k, \beta_k)$$

**Algorithme TS-Beta :**

1.  Initialisation ➜ $\alpha_k = 1, \beta_k = 1$ pour tout $k$ (Prior uniforme, "flat prior").
2.  À chaque pas de temps $t$
    * Tirer un échantillon $\hat{\theta}_k \sim \text{Beta}(\alpha_k, \beta_k)$ pour chaque bras.
    * Choisir l'action $a_t = \arg\max_k \hat{\theta}_k$.
    * Recevoir la récompense $r_t$.
    * Mise à jour bayésienne
        * Si $r_t = 1 ➜ \alpha_{a_t} \leftarrow \alpha_{a_t} + 1$
        * Si $r_t = 0 ➜ \beta_{a_t} \leftarrow \beta_{a_t} + 1$

> **Nota ➜** L'élégance de cette méthode réside dans le fait que l'exploration est induite par la variance de la distribution Bêta. Au début (peu de données), la distribution est large (grande variance), donc les échantillons $\hat{\theta}$ sont dispersés $\rightarrow$ forte exploration. À mesure que les données s'accumulent, la distribution se resserre autour de la vraie moyenne (faible variance) $\rightarrow$ forte exploitation[^1].

## **Analyse de Performance et Regret**

Pendant près de 80 ans, le Thompson Sampling a été considéré comme une simple heuristique sans garantie. Ce n'est qu'en 2012 que Agrawal et Goyal ont fourni la preuve formelle de son optimalité asymptotique.

### **Bornes de Regret**

Pour le problème de bandit stochastique à $K$ bras avec des récompenses Bernoulli, le regret attendu du Thompson Sampling satisfait :

$$\mathbb{E}[R_T] \leq (1 + \epsilon) \sum_{k: \Delta_k > 0} \frac{\ln T}{D_{KL}(\mu_k || \mu^*)} \Delta_k + O\left(\frac{K}{\epsilon^2}\right)$$

Où :
* $\Delta_k = \mu^* - \mu_k$ est le "gap" de sous-optimalité du bras $k$.
* $D_{KL}$ est la divergence de Kullback-Leibler.

Cette borne est logarithmique en temps ($\ln T$), ce qui correspond à la borne inférieure théorique de Lai et Robbins (1985). Autrement dit, **on ne peut pas faire théoriquement mieux** (à une constante près).

### **Comparaison TS vs UCB**

Bien que UCB et TS partagent les mêmes bornes de regret asymptotiques :
* **Empiriquement :** TS surpasse souvent UCB sur des horizons finis, car il est moins conservateur.
* **Robustesse :** TS gère mieux les récompenses retardées (*delayed feedback*) et les environnements non-stationnaires (si l'on ajoute un facteur d'oubli).

## **Extension au Contextual Bandit (Bandits Contextuels)**

Dans la pratique industrielle (Netflix, Amazon), la décision ne dépend pas uniquement de l'historique des récompenses, mais d'un **contexte** $x_t$ (profil utilisateur, heure de la journée).

On utilise alors le **Linear Thompson Sampling (LinTS)**. On suppose une relation linéaire entre le contexte et la récompense attendue : $\mathbb{E}[r_t | x_t] = x_t^\top \theta^*$.

L'algorithme maintient une distribution gaussienne multivariée sur le vecteur de poids $\theta$ :

$$\theta \sim \mathcal{N}(\hat{\theta}, B^{-1})$$

À chaque étape, on échantillonne un vecteur de paramètres $\tilde{\theta}$ et on choisit le bras qui maximise $x_{t,a}^\top \tilde{\theta}$.

## **Implémentation Python (Prototype Académique)**

Implémentation vectorisée minimale pour le cas Beta-Bernoulli.
```python
import numpy as np

class ThompsonSampling:
    """
    Implémentation de l'échantillonnage de Thompson pour le problème du Bandit Manchot (Beta-Bernoulli).
    """
    def __init__(self, n_arms):
        self.n_arms = n_arms
        # Initialisation des hyperparamètres a priori (Prior Beta(1,1) -> Uniforme)
        self.alphas = np.ones(n_arms)
        self.betas = np.ones(n_arms)

    def select_arm(self):
        """
        Sélectionne le bras à jouer en échantillonnant depuis la distribution postérieure.
        """
        # Étape stochastique clé : tirage dans la loi Beta
        theta_samples = np.random.beta(self.alphas, self.betas)
        return np.argmax(theta_samples)

    def update(self, arm, reward):
        """
        Mise à jour bayésienne des hyperparamètres suite à une observation.
        """
        if reward == 1:
            self.alphas[arm] += 1
        else:
            self.betas[arm] += 1
```
L'échantillonnage de Thompson représente un triomphe de l'approche bayésienne. Il offre un mécanisme élégant, sans paramètre arbitraire (contrairement au coefficient d'exploration de $\epsilon$-greedy), qui s'adapte naturellement à l'incertitude des données. Son utilisation est aujourd'hui standard dans les systèmes de recommandation modernes et les essais cliniques adaptatifs.
---
> CF.
1. Thompson, W. R. (1933). On the likelihood that one unknown probability exceeds another in view of the evidence of two samples. Biometrika, 25(3-4), 285-294. (L'article fondateur).
1. Chapelle, O., & Li, L. (2011). An Empirical Evaluation of Thompson Sampling. Advances in Neural Information Processing Systems (NIPS). (L'article de la "redécouverte").
1. Agrawal, S., & Goyal, N. (2012). Analysis of Thompson Sampling for the Multi-armed Bandit Problem. COLT 2012. (Preuve des bornes logarithmiques).
1. Sutton, R. S., & Barto, A. G. (2018). Reinforcement Learning: An Introduction. MIT Press.
1. Russo, D., et al. (2018). A Tutorial on Thompson Sampling. Foundations and Trends® in Machine Learning.