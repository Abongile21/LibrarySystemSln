# Presentation: Library Manager Console App (.NET 9.0)

Welcome to the brief presentation of the **Library Manager Console App**, a C# application built with extensibility, robustness, and user-centered interaction in mind.

---

## Design Philosophy

We started with **Object-Oriented Programming** at the core. The system uses a clear **inheritance hierarchy**:

- `LibraryItem` is the **abstract base class** with common properties: `ID`, `Title`, and `YearPublished`.
- We then extend it into three specialized classes:  
  - `Book` → adds `Author`, `Genre`  
  - `Magazine` → adds `IssueNumber`, `Month`  
  - `DVD` → adds `Director`, `Duration`

This approach ensures that shared behavior is centralized, and type-specific properties are cleanly isolated.

---

## Collection Choice

We chose a `Dictionary<string, LibraryItem>` for storing items. Why?

- Fast **O(1) lookup** using the ID.
- Ensures **uniqueness** of items.
- Simple to **add, remove, and display** entries.

This makes it both efficient and easy to manage for a console application.

---

## Improved Search Strategy

Search is **not limited to just ID**. We enhanced it to also:

- Match partial or full **titles**.
- Handle **case-insensitive** queries for filter by library item.
- Return **multiple results**, if applicable(filter).
- Gracefully inform the user if no match is found.

This enhances the usability, especially for larger collections.

---

## Error Handling & User Safety

Robust error handling includes:

- `try-catch` blocks for parsing inputs (e.g., invalid numbers or timespans).
- Preventing duplicate IDs.
- Informative error messages.
- Safe fallback when operations fail (e.g., not crashing on invalid search/removal).


---

## Extensibility

The architecture allows easy future upgrades:
- Add new item types by extending `LibraryItem`.
- Implement  storage (e.g., JSON or database).
- Wrap the core logic into an API or GUI.

---

## Conclusion

This app demonstrates a solid grasp of object-oriented design, efficient data structures, and clean console UI practices. Its thoughtful error handling and flexible search system elevate it above the typical CRUD CLI app.



---

Thank you! 
