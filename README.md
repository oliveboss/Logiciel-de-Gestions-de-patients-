# Logiciel-de-Gestions-de-patients-
Logiciel conçue  avec la programmation orientée objet basée sur le C++ et utilisant l'architecture Clean 
# Logiciel de Gestion de Patients 🏥💻

## Description
Le **Logiciel de Gestion de Patients** est une application conçue en C++ en utilisant les principes de la programmation orientée objet (POO). L'application adopte une **architecture Clean** afin de maintenir une séparation claire des responsabilités et garantir une évolutivité et une testabilité accrues.

Ce logiciel permet de gérer les informations des patients, y compris les consultations, les diagnostics, et l'historique médical. Il peut être utilisé dans des environnements de santé tels que des hôpitaux ou des cliniques pour organiser et suivre les données des patients de manière efficace.

## Fonctionnalités
- **Gestion des Patients** : Ajouter, modifier, supprimer et consulter les informations des patients.
- **Gestion des Consultations** : Enregistrer les consultations avec les détails de chaque visite médicale.
- **Historique Médical** : Suivre l'historique des traitements et des diagnostics des patients.
- **Consultations par Médecin** : Associer chaque consultation à un médecin et suivre l'évolution de la santé du patient.
- **Structure modulaire** : Application construite sur une architecture Clean, favorisant une séparation nette des préoccupations (business logic, présentation, etc.).
  
## Technologies utilisées
- **C++** : Langage de programmation orientée objet utilisé pour développer le logiciel.
- **Architecture Clean** : Utilisation de principes de l'architecture Clean pour organiser le code, avec des couches comme `Entities`, `UseCases`, `Interface`, et `Adapters`.
- **Fichiers texte ou bases de données (optionnel)** : Stockage des données des patients dans des fichiers ou une base de données, selon l'implémentation.

## Architecture
L'architecture Clean repose sur la séparation du code en différentes couches :
1. **Entities (Entités)** : Représentent les objets principaux du domaine, comme les patients, les médecins, et les consultations.
2. **UseCases (Cas d'utilisation)** : Contiennent la logique métier qui définit les actions possibles, comme l'ajout d'un patient ou la consultation de l'historique médical.
3. **Interface (Interface)** : Définit les interfaces de communication entre les différentes couches.
4. **Adapters (Adaptateurs)** : Fournissent l'implémentation des interfaces définies dans les couches supérieures, comme l'accès à la base de données ou l'interface utilisateur.

## Installation

### Prérequis
- Un compilateur C++ compatible (comme GCC ou Clang).
- Un éditeur de texte ou un IDE pour le développement (par exemple, Visual Studio Code, CLion).
- Si nécessaire, une base de données (par exemple, SQLite, MySQL) ou des fichiers pour stocker les données des patients.

### Étapes d'installation
1. Clonez le dépôt sur votre machine locale :
   ```bash
   git clone https://github.com/oliveboss/Logiciel-de-Gestions-de-patients.git
