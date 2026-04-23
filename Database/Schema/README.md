# Database Schema Scripts

These scripts provide a human‑readable, versioned representation of the current **StudentDB** database structure so contributors don’t have to rely only on the binary `.bacpac` file.

> Goal: Establish a baseline. Future improvements can refine data types, add migrations, and automate validation in CI.

## Files & Execution Order

| Order | File | Purpose |
|-------|------|---------|
| 01 | `01-tables.sql` | Creates core tables (Bus, Library, Student, Users) |
| 02 | `02-constraints-indexes.sql` | Adds primary keys & foreign keys (editable) |
| 10 (optional) | `Seed/10-minimal-lookup.sql` | Reserved for minimal seed data if ever required |

## How to Use (Manual)
1. Create (or ensure) an empty database named `StudentDB` in SQL Server:
   ```sql
   IF DB_ID('StudentDB') IS NULL
       CREATE DATABASE StudentDB;
   GO
   ```
2. Open the `StudentDB` database context in SSMS.
3. Run: `01-tables.sql`.
4. Run: `02-constraints-indexes.sql`.
5. (If present) Run any seed scripts under `Seed/`.

## Important Notes / Assumptions
* Column definitions here were inferred from the typed dataset (`StudentDBDataSet.xsd`). If the live database uses different lengths, nullability rules, or data types (e.g., numeric / date types), please adjust and submit a PR.
* Primary keys & foreign keys were chosen conservatively; update them if the actual schema differs. In particular, if surrogate identity keys exist in the live DB, replace the inferred composite or natural keys here.
* Text fields are set to `NVARCHAR(255)` as a safe placeholder based on the dataset’s `maxLength` attributes.
* Binary image fields (`Photo`, `DP`) are scripted as `IMAGE` to mirror legacy usage; consider migrating to `VARBINARY(MAX)` in a future modernization issue.
* No triggers, views, or stored procedures were included (none were detected in the dataset). Add them if they exist in the actual database.

## Contributing Workflow for Schema Changes
When you add or modify a table/column:
1. Update `01-tables.sql` (or add a new incremental script in a future migration phase).
2. Update or add constraints/indexes in `02-constraints-indexes.sql`.
3. Run scripts on a scratch DB to verify they succeed.
4. Mention the change in your PR description.

## Future Phases (Separate Issues)
| Phase | Description |
|-------|-------------|
| 2 | Introduce incremental migration pattern (e.g., numbered `migrations/` folder) |
| 3 | Add GitHub Action to build a SQL Server container & apply scripts |
| 4 | Add idempotent guards (`IF NOT EXISTS`) or swap to migration tooling |
| 5 | Normalize data types (use `DATE`, `INT`, etc., instead of generic NVARCHAR) |

## Verification Checklist (For Reviewers)
- [ ] Scripts run cleanly on empty `StudentDB` DB.
- [ ] Tables & columns match current application expectations (typed dataset & queries).
- [ ] Keys/relationships reflect intent (update if actual DB differs).

## Disclaimer
This initial baseline is intentionally conservative. Adjustments are welcome via PRs that include a brief rationale (e.g., “Changed `Paid_date` to DATE from NVARCHAR(255)”).

---
Happy contributing! 🚀
