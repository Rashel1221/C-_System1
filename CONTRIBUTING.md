# Contributing to Student Management System

Thanks for your interest in contributing to **Student Management System**, every contribution helps, and it’s especially appreciated for Hacktoberfest 2025! 🎉

This document explains how to file issues, propose changes, and submit pull requests so your contribution can be reviewed and merged quickly.

---

## Table of Contents

* [Getting Started](#getting-started)
* [How to Contribute](#how-to-contribute)

  * [Report a bug / Request a feature](#report-a-bug--request-a-feature)
  * [Work on an issue](#work-on-an-issue)
  * [Create a pull request (PR)](#create-a-pull-request-pr)
* [Branching & Commit Guidelines](#branching--commit-guidelines)
* [Coding Standards](#coding-standards)
* [Database & Connection notes](#database--connection-notes)
* [Testing & Manual QA](#testing--manual-qa)
* [Maintainers & Review Process](#maintainers--review-process)
* [Good First Issues / Hacktoberfest Tips](#good-first-issues--hacktoberfest-tips)

---

## Getting Started

### Prerequisites

* Windows 10/11
* Visual Studio 2022 (recommended) with .NET Framework development workload
* SQL Server (2021 recommended) and SQL Server Management Studio (SSMS)

### Local setup

1. Fork the repository and clone your fork:

```bash
git clone https://github.com/<your-username>/Student_Management_System.git
cd Student_Management_System
```

2. Open `SMS.sln` in Visual Studio.

3. Import the database (provided `.bacpac`) into SSMS if you want the seed data and schema locally.

   * In SSMS: Right click on **Databases** → **Import Data-tier Application** → choose the `.bacpac` file provided in the repo (if present) → set the database name to `School` (or update connection strings accordingly).

4. Update connection strings in the project `.cs` files to match your local SQL Server instance. (Search for `Data Source=` or the string used in `README.md`.)

5. Build and run the WinForms application from Visual Studio.

---

## How to Contribute

### Report a bug / Request a feature

* Open an issue and use clear, descriptive titles.
* For bugs include:

  * Steps to reproduce
  * Expected behavior vs. actual behavior
  * Screenshots or error messages / stack traces
  * Your environment (Windows version, Visual Studio, SQL Server version)

### Work on an issue

1. Comment on the issue you plan to work on. This prevents duplicate work.
2. Create a branch from `main` with a descriptive name:

```
git checkout -b feat/student-search
# or
git checkout -b fix/login-connection-string
```

3. Make changes in your branch, run the application and test manually.
4. Keep commits small and focused.

### Create a pull request (PR)

1. Push your branch to your fork:

```
git push origin <branch-name>
```

2. Open a Pull Request against `RabindranathChanda/Student_Management_System:main`.
3. In the PR description include:

   * What you changed and why
   * Any setup steps required to test
   * Screenshots or short GIFs (if UI changes)
4. Use the PR template (example below) or include the same info in your PR body.

**PR template suggestion**

```
### Summary
A short summary of the change.

### Related issue
Fixes #<issue-number> (if applicable)

### How to test
1. Steps to reproduce or validate locally

### Notes
Any additional info (breaking changes, migration notes, DB changes)
```

---

## Branching & Commit Guidelines

**Branch names**

* `feat/<short-description>` for new features
* `fix/<short-description>` for bug fixes
* `chore/<short-description>` for non-functional changes

**Commit messages**

* Use present tense and keep it brief.
* Example: `Add student search by admission number` or `Fix SQL connection string error on startup`

---

## Coding Standards

This is a C# WinForms project targeting .NET Framework 4.8.1. Keep code consistent and maintainable:

* Follow standard C# naming conventions (PascalCase for types and methods, camelCase for parameters and local variables).
* Keep methods small and single-purpose.
* Avoid hard-coded connection strings, use a single configuration location or clearly commented placeholders.
* When adding SQL, prefer parameterized queries or stored procedures to avoid SQL injection.
* Add comments where logic is non-obvious.

---

## Database & Connection notes

* The project uses **SQL Server**. If you import the provided `.bacpac`, the default database name used by the README is `School`.
* **Important security note:** Do not commit production connection strings, credentials, or backups containing sensitive data. Use environment-specific values and document how to configure them locally.
* If you add migration scripts or a new `.bacpac`, mention it in your PR and update the README.

---

## Testing & Manual QA

* This repo currently does not include automated tests. When you add new features, please:

  * Document manual testing steps in your PR
  * Add unit tests if you introduce business logic that can be tested outside the UI

* Common manual tests:

  * Add a student → verify entry in DB
  * Edit a student → verify values update correctly
  * Search/filter features → verify results

---

## Maintainers & Review Process

* PRs will be reviewed by project maintainers. Expect feedback requesting changes, please address review comments by pushing additional commits to the same branch.
* Keep PRs focused: one feature/fix per PR is ideal.

---

## Good First Issues / Hacktoberfest Tips

If you’re participating in Hacktoberfest 2025, look for issues labeled `good-first-issue` (or ask in Issues for something approachable). Some good starter ideas:

* UI polish for forms (labels, validation messages)
* Add client-side validation before saving to DB
* Improve README with screenshots and setup steps for newbies

---

## Thanks!

Thanks for taking the time to improve the project — PRs, issues, and suggestions are all welcome. If you need help getting started, open an issue with the label `help wanted` and describe what you'd like to work on.

Happy hacking!!!
