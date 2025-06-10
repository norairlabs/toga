# TOGA

**TOGA** is Norairlabs’ open-source connectivity software for flight- and vehicle-simulation hardware. It bridges your favorite simulators (MSFS, X-Plane, Aerowinx, and more) with Norairlabs’ modular cockpit components, unlocking seamless integration and community-driven customization.

- 🔗 **Open Source** under the MIT License  
- ✈️ Supports **Microsoft Flight Simulator**, **X-Plane**, **Aerowinx**
- 🔌 Implements the **NorAirFrame Protocol** (open spec) for direct hardware control
- 🎛️ Includes **device profiles** for quick sim/aircraft switching
- 📦 Ship-ready **SDK** with examples to jump-start your own integrations

---

## 🚀 Features

1. **Seamless Simulator Connectivity**  
   - Real-time bidirectional data exchange with MSFS, X-Plane, Aerowinx, etc.  
2. **Modular Hardware Control**  
   - Drive annunciator LEDs, switches, push-buttons, and more via software.  
3. **Profiles & Presets**  
   - Save/load custom configurations per simulator and aircraft.  
4. **NorAirFrame Protocol**  
   - Open-standard binary protocol for low-latency, high-throughput hardware interfacing.  
5. **Extensible SDK**  
   - Example code & libraries to build custom apps or CLI tools.

---

## 🛠 Installation

### 1. Download a Release  
Grab the latest prebuilt binaries (Windows, macOS, Linux) from the [GitHub Releases page](https://github.com/norairlabs/toga/releases).

### 2. Build from Source  
```bash
# Clone the repo
git clone https://github.com/norairlabs/toga.git
cd toga
```

### 3. Restore & Build
```bash
dotnet restore
dotnet build --configuration Release
```

### 3. Run
```bash
dotnet run --configuration Release
```

## 🤝 Contributing

Contributions are very welcome! Please:

- Fork this repo
- Create a branch (`git checkout -b feat/my-feature`)
- Make changes & add tests/examples
- Update docs in this README or `/docs`
- Open a Pull Request against `main`

See [CONTRIBUTING.md](./CONTRIBUTING.md) for coding standards and commit conventions.

---

## 📜 License

Licensed under the MIT License. See [LICENSE](./LICENSE.md) for details.

---

## ✉️ Support

- **Email:** team@norairlabs.com  
- **Documentation & Downloads:** [https://norairlabs.com/toga/](https://norairlabs.com/toga/)  

Made with ❤️ in the European Union.  
Norairlabs — *where open source meets limitless skies.*


