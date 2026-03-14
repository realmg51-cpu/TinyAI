# TinyAI 🤖

A lightweight, rule-based AI written in C# for learning purposes.

## 📖 What is it?

**TinyAI** is a simple rule-based artificial intelligence program built with C#. It demonstrates fundamental AI concepts through pattern matching and predefined rules.

## 🎯 Purpose

This project was created to:
- Learn how rule-based AI systems work
- Practice and improve C# programming skills
- Understand basic AI concepts through hands-on coding

## 🚀 Getting Started

### Prerequisites

Before you begin, ensure you have the following installed:
- [.NET SDK 8.0](https://dotnet.microsoft.com/download) (or later)
- [Git](https://git-scm.com/downloads) (for cloning)

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/realmg51-cpu/TinyAI.git
   ```
   1. Navigate to the project directory
   ```bash
   cd TinyAI
   ```
2. Build the project
   On Windows:
   ```bash
   build.cmd
   ```
   On Linux/macOS:
   ```bash
   chmod +x build.sh
   ./build.sh
   ```
   Or using .NET CLI directly:
   ```bash
   dotnet build
   ```
3. Run TinyAI
   ```bash
   dotnet run
   ```
   Or run the executable from the output/ folder:
   ```bash
   # Windows
   output\TinyAI.exe
   
   # Linux/macOS
   output/TinyAI
   ```

## 🐳 Running with Docker

### Prerequisites
- [Docker](https://docs.docker.com/get-docker/) installed on your system

### Quick Start

1. **Build the Docker image**
   ```bash
   docker build -t tinyai .
```

1. Run the container
   ```bash
   docker run --rm tinyai
   ```

Advanced Usage

Interactive mode (if your app needs user input)

```bash
docker run -it --rm tinyai
```

Run with a specific name

```bash
docker run --name tinyai-container tinyai
```

List your Docker images

```bash
docker images
```

List running containers

```bash
docker ps
```

Stop a running container

```bash
docker stop tinyai-container
```

Remove a container

```bash
docker rm tinyai-container
```

Remove the Docker image

```bash
docker rmi tinyai
```

Docker Commands Cheat Sheet


Example Output

When you run TinyAI in Docker, you should see something like:

```bash
$ docker run --rm tinyai
=== TinyAI ===
Initializing rule-based AI...
Loading rules...
Ready!
> 
```
### Docker Commands Cheat Sheet

| Command | Description |
|---------|-------------|
| `docker build -t tinyai .` | Build the Docker image |
| `docker run --rm tinyai` | Run and auto-remove container |
| `docker run -it --rm tinyai` | Run in interactive mode |
| `docker ps` | List running containers |
| `docker ps -a` | List all containers |
| `docker images` | List all images |
| `docker stop <container>` | Stop a running container |
| `docker rm <container>` | Remove a container |
| `docker rmi tinyai` | Remove the image |
Notes

· The --rm flag automatically removes the container when it stops
· Use -it flags for interactive applications that need keyboard input
· The Docker image is based on .NET 8.0 runtime for minimal size




💡 How It Works

TinyAI uses a simple rule-based system where:

· Input is processed and matched against predefined patterns
· Responses are triggered based on matching rules
· The system can be extended by adding new rules

🛠️ Project Structure

```text
TinyAI/
├── src/
│   └── Main.cs           # Main source code
├── TinyAI.csproj         # Project configuration
├── build.cmd             # Windows build script
├── build.sh              # Unix build script
├── .gitignore            # Git ignore rules
└── README.md             # This file

```

---

🤝 Join the Community

Want to discuss, learn, and grow together? Join our Discord server!

[![Join our Discord](https://img.shields.io/badge/Discord-7289DA?style=for-the-badge&logo=discord&logoColor=white)](https://discord.gg/wbBCZkenT)

📝 License

This project is open source and available under the MIT License.

⭐ Contributing

Feel free to:

· Report bugs
· Suggest new features
· Submit pull requests
· Share your ideas on Discord

---

Happy coding! 🎉
