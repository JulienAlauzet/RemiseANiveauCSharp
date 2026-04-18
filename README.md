# Formation et Remise à Niveau C#/.NET

Ce dépôt GitHub contient les exercices pratiques et l'architecture de solution réalisés dans le cadre de ma formation de mise à niveau sur les fondamentaux du C# moderne (.NET 8+). 

L'objectif de ce projet est de démontrer ma capacité à concevoir une architecture de solution standardisée, à manipuler des données avec LINQ, et à valider la logique métier par des tests unitaires (xUnit), tout en effectuant une transition de compétences depuis l'environnement WinDev vers l'écosystème .NET.

## Architecture de la Solution

La solution est structurée selon les standards de l'industrie pour assurer le découplage et la testabilité :
- **Prepa_ExamSII** : Projet principal (Application Console) contenant le code métier, les modèles de données et la logique d'asynchronisme.
- **Prepa_ExamSII.Tests** : Projet de tests unitaires utilisant xUnit, référençant le projet principal.

## Compétences Démontrées

### 1. Programmation Orientée Objet & Architecture
- Conception de classes (`Vehicule.cs`) avec propriétés auto-implémentées.
- Implémentation d'interfaces (`IVendable.cs`) pour le découplage et la composition.
- Utilisation de méthodes d'extension (`ExtensionVendable.cs`) pour étendre les capacités d'une interface sans la modifier (principe Ouvert/Fermé de SOLID).

### 2. Modern C# Syntax & Features
- Utilisation du type **`decimal`** pour une gestion monétaire précise (Prix).
- Syntaxe concise avec le **"target-typed new"** (`new(...)`).
- Utilisation de **Tuples** pour des projections de données légères.

### 3. Manipulation de Données (LINQ)
- Filtrage avancé avec **`.Where()`**.
- Projection de données avec **`.Select()`**.
- Agrégation de données avec **`.Average()`** et **`.Count()`**.
- Groupement de données complexe avec **`.GroupBy()`**.

### 4. Asynchronisme (async/await)
- Simulation d'un appel API/Base de données asynchrone avec `Task.Delay()`.
- Implémentation du pattern `async`/`await` dans une méthode de chargement de données.

### 5. Tests Unitaires (xUnit)
- Rédaction de tests unitaires robustes suivant le pattern **AAA** (Arrange, Act, Assert).
- Validation de la logique métier (calculs de remises) et des cas limites.

## Comment lancer les tests

Pour exécuter les tests unitaires depuis Visual Studio :
1. Ouvrir la solution (`.sln`).
2. Ouvrir l'**Explorateur de tests** (`Test` > `Explorateur de tests`).
3. Cliquer sur "Exécuter tout".
