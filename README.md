# 📘 EventEase – Event Management Blazor App

**EventEase** is a fictional company specializing in corporate and social event management. This web application was developed to allow users to:
- Browse events with details like name, date, and location
- View individual event details
- Register for events via a form with validation
- Track attendance across events
- Maintain user session state across pages

Built with **Blazor WebAssembly**, this app was developed in three structured activities, leveraging **Microsoft Copilot** at every step to assist with code generation, debugging, optimization, and deployment.

---

## 🚀 Features

- 🧾 **Event Card Component** – Displays dynamic event details (name, date, location)
- 🔗 **Client-Side Routing** – Seamless navigation between list, details, and registration pages
- 📝 **Registration Form** – Includes input validation
- 👥 **Attendance Tracker** – Tracks event participation
- 🧠 **Session State Management** – Maintains user login status
- ☁️ **GitHub Pages Deployment** – Hosted at [https://melodiedejong.github.io/EventMgr/](https://melodiedejong.github.io/EventMgr/)

---

## 🛠️ Getting Started

### Prerequisites
- [.NET SDK 8+](https://dotnet.microsoft.com/download)
- Visual Studio or Visual Studio Code
- Git

### Running Locally
```bash
git clone https://github.com/melodiedejong/EventMgr.git
cd EventMgr
dotnet run
```

---

## 🧱 Project Structure

| Folder / File         | Purpose                                       |
|------------------------|-----------------------------------------------|
| `Pages/`               | Contains main Razor pages (List, Details, Registration) |
| `Components/EventCard.razor` | Reusable component for displaying event data |
| `Services/SessionState.cs` | Manages user login session in-memory |
| `wwwroot/`             | Static assets for deployment                  |

---

## 🧠 How Copilot Assisted Throughout the Project

This project was developed in three phases. Here's how Microsoft Copilot contributed:

### **Activity 1: Foundational Build**
- Helped scaffold the initial `EventCard.razor` component
- Suggested syntax for data binding and formatting event fields
- Provided guidance on setting up `@page` routes and `NavLink` navigation

### **Activity 2: Debugging & Optimization**
- Identified missing input validation logic and recommended fixes
- Suggested graceful handling of invalid routes
- Assisted in switching to `async` data-fetching for performance gains

### **Activity 3: Feature Expansion**
- Generated the full `SessionState` service class for user tracking
- Introduced the Blazored.LocalStorage library for local event persistence
- Converted absolute `<a href>` links to relative `NavLink` components for GitHub Pages routing
- Guided through proper deployment steps via Bash and Git (e.g., `.nojekyll`, `404.html`)

> **Note:** Copilot was most useful when implementing features incrementally. Large-scale Copilot-generated code was often refined or rewritten manually for better control and understanding.

---

## 🚢 Deploying to GitHub Pages

1. **Build the app:**
   ```bash
   dotnet publish EventMgr.csproj -c Release -o dist
   ```

2. **Prepare deployment files:**
   ```bash
   cd dist/wwwroot
   cp index.html 404.html
   touch .nojekyll
   ```

3. **Deploy to `gh-pages` branch:**
   ```bash
   git init
   git checkout -b gh-pages
   git remote add origin https://github.com/melodiedejong/EventMgr.git
   git add .
   git commit -m "Deploy EventEase app"
   git push -f origin gh-pages
   ```

4. **Set GitHub Pages Source**:  
   - Branch: `gh-pages`  
   - Folder: `/ (root)`

---

## ⚠️ Known Limitations

- No backend API or database — all data is client-side
- Event data resets on refresh unless stored locally
- GitHub Pages routing is case-sensitive

---

## 📚 Credits & Acknowledgments

- Microsoft Copilot – AI-assisted development support
- Blazored.LocalStorage – Client-side persistence
- .NET / Blazor Team – Framework and documentation
- Project developed for [Your Course Name / Instructor Name]
