## Mini To-Do List

### Overview
The **Mini To-Do List** is a simple task management application built using C# and Blazor Web Assembly. It allows users to create, update, and delete tasks, helping them stay organized and focused.

### Key Features
1. **Task Creation**: Users can add new tasks to their to-do list.
2. **Task Details**: Each task includes a title, description, due date, and status (e.g., pending, completed).
3. **Task Update**: Users can edit task details, such as changing the title, description, or due date.
4. **Task Deletion**: Tasks can be removed from the list when they are no longer needed.
5. **Task Status**: Users can mark tasks as completed or pending.
6. **Responsive Design**: The application adapts to different screen sizes, making it usable on both desktop and mobile devices.

### How It Works
1. **Task Creation**:
   - Users input task details (title, description, due date) and click the "Add" button.
   - The application stores the task in the database.
2. **Task Display**:
   - The list of tasks is fetched from the database and displayed on the UI.
   - Each task shows its title, description, due date, and status.
3. **Task Update**:
   - Users click the "Edit" button next to a task.
   - The task details are loaded into an edit form.
   - After making changes, users click "Save" to update the task.
4. **Task Deletion**:
   - Users click the "Delete" button next to a task.
   - The task is removed from the list and deleted from the database.
5. **Task Status Change**:
   - Users can toggle the status (completed/pending) of a task.
   - The UI updates accordingly, and the database reflects the change.