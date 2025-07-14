# ELKServiceStatus

A lightweight Windows Forms application to monitor log files from your ELK stack services (Elasticsearch, Logstash, Kibana, Fleet Server). Displays the last 100 lines of each service’s log file and supports manual refresh or real-time tailing.

---

<img width="1011" height="311" alt="image" src="https://github.com/user-attachments/assets/21b84cd2-e335-442e-be8a-01e078d614b5" />

<img width="1705" height="902" alt="image" src="https://github.com/user-attachments/assets/f9c1b464-4a66-4689-aef5-bb9f50e08df4" />

---

## 🖥 Features

- ✅ Displays logs for selected ELK services
- ✅ Shows **only the last 100 lines** for performance (tunable)
- ✅ Read-only, scrollable RichTextBox viewer
- ✅ Manual refresh or real-time tail (`tail -f`) mode
- ✅ Configurable service names and log file paths via `Settings`

---

## 📦 Prerequisites

- .NET Framework 4.7.2 or higher
- Windows OS (tested on Windows 10/11)
- Read access to log files for:
  - Elasticsearch
  - Logstash
  - Kibana
  - Fleet Server

---

## ⚙️ Configuration

Update the `Properties > Settings.settings` file with your actual service names and log file paths:

| Setting Name        | Type    | Example Value                          |
|---------------------|---------|----------------------------------------|
| `esServiceName`     | string  | `elasticsearch-service-x`              |
| `esLog`             | string  | `D:\ELK\logs\elasticsearch.log`        |
| `kbServiceName`     | string  | `kibana-service-x`                     |
| `kbLog`             | string  | `D:\ELK\logs\kibana.log`               |
| `fsServiceName`     | string  | `filebeat-service-x`                   |
| `fsLog`             | string  | `D:\ELK\logs\Elastic\Agent\agent.log`  |
| `lsServiceName`     | string  | `logstash-service-x`                   |
| `lsLog`             | string  | `D:\ELK\logs\logstash.log`             |

You can modify these values via the Visual Studio **Settings Designer** or `Settings.settings` XML.

---

## 🚀 How to Use

1. Build and run the application.
2. Select a service from the dropdown menu.
3. Click **Refresh** to load the log manually, or
4. Click **Tail Log** to continuously update in real-time (like `tail -f`).
5. Click **Stop** to pause tailing and enable manual refresh again.

---

## 🛠 Development

### Build Instructions:
1. Open the solution in Visual Studio.
3. Build the project (`Ctrl + Shift + B`).
4. Run (`F5`) or publish using `Right Click > Publish`.

---

## 📝 License

This is a FOSS project

---

## 🙌 Acknowledgments

- .NET Framework WinForms
- ELK Stack for log generation
- Users and teams working with infrastructure monitoring
