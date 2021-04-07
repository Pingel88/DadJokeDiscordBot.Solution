<br>
<p align="center">
  <u><big>|| <b>Travis Scott Discord Bot</b> || </big></u>
</p>
<br>
<p align="center">
  <img width="200" src="https://cdn.discordapp.com/attachments/828833580250562580/829008098969911346/Screen_Shot_2021-04-05_at_4.32.27_PM.png">
  <p align="center">
    ___________________________
  </p>
  <p align="center">
    <a href="https://github.com/Pingel88">
      <strong>Mike Pingel</strong> | 
    </a>
    <a href="https://github.com/MorganJBradford">
      <strong>Morgan Bradford</strong> | 
    </a>
    <a href="https://github.com/Jeroenemo">
      <strong>Jeroen van Seeters</strong> | 
    </a>
    <a href="https://github.com/levi-kohler">
      <strong>Levi Kohler</strong>
    </a>
  </p>
  <p align="center">
    <a href="https://github.com/Pingel88/TravisScottDiscordBot.Solution/graphs/contributors">
      <img src="https://img.shields.io/github/contributors/Pingel88/TravisScottDiscordBot.Solution.svg?style=plastic">
    </a>
    ¨
    <a href="https://github.com/Pingel88/TravisScottDiscordBot.Solution/stargazers">
      <img src="https://img.shields.io/github/stars/Pingel88/TravisScottDiscordBot.Solution.svg?color=yellow&style=plastic">
    </a>
    ¨
    <a href="https://github.com/Pingel88/TravisScottDiscordBot.Solution/issues">
      <img src="https://img.shields.io/github/issues/Pingel88/TravisScottDiscordBot.Solution?style=plastic">
    </a>
    ¨
    <img src="https://img.shields.io/github/issues-pr-closed/pingel88/TravisScottDiscordBot.Solution?style=plastic">
    ¨
    <img src="https://img.shields.io/docker/automated/jeroenvanseeters/discord-bot?color=green&style=plastic">
    ¨
    <a href="https://github.com/Pingel88/Best-ReadMe-Template/blob/master/LICENSE.txt">
      <img src="https://img.shields.io/badge/License-MIT-yellow.svg?style=plastic">
    </a>
  </p> 
</p>

<p align="center">
  <small>Initiated April 4th, 2021, Updated April 8th, 2021</small>
</p>
<p align="center">
    <a href="https://github.com/Pingel88/TravisScottDiscordBot.Solution"><big>Project Docs</big></a> ·
    <a href="https://github.com/Pingel88/TravisScottDiscordBot.Solution/issues"><big>Report Bug</big></a> ·
    <a href="https://github.com/Pingel88/TravisScottDiscordBot.Solution/issues"><big>Request Feature</big></a>
</p>

## 🌐 About the Project

### 📖 Description
A Discord bot that acts as a dad joke supplement to replace one of our retired instructors at [Epicodus](https://www.epicodus.com/). Written in C#/.NET, it utilizes an API via RESTful principles, WebSocket protocol, and Docker Containerization for remote server hosting. 
<br>
<br>
Although no setup is required to simply invite the bot to your discord channel, if you would like to download, alter, or deploy the source code yourself, follow along with the instructions detailed in the [Getting Started](##🏁-getting-started) Section.
<br>
<br> 
Otherwise, skip to the [Add OUR Bot](##🛰️-add-our-bot) Section to get started by adding the bot directly to your own discord guild. 

### 🦠 Known Bugs

* It's too perfect.

### 🛠 Built With

* [Visual Studio Code](https://code.visualstudio.com/)
* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [.NET Core 2.1](https://dotnet.microsoft.com/download/dotnet/2.1)
* [Discord.Net](https://docs.stillu.cc/)
* [RapidAPI](https://rapidapi.com/KegenGuyll/api/dad-jokes)
* [Docker](https://www.docker.com/)
* [DigitalOcean](https://cloud.digitalocean.com/)
* [Git & GitHub](https://github.com/)

------------------------------

## 🏁 Getting Started

### 📋 Prerequisites

### Install .NET Core 2.1
**NOT compatible with .NET 5.0**
* On macOS Mojave or later
  * [Click here](https://dotnet.microsoft.com/download/dotnet/2.1) to download the .NET Core SDK from Microsoft Corp for macOS.
* On Windows 10 x64 or later
  * [Click here](https://dotnet.microsoft.com/download/dotnet/2.1) to download the 64-bit .NET Core SDK from Microsoft Corp for Windows.

#### Install dotnet script
 Enter the command ``dotnet tool install -g dotnet-script`` in Terminal for macOS or PowerShell for Windows.

#### Install Docker
(Optional, for remote hosting)[Download and Install Docker](https://www.docker.com/products/docker-desktop)

#### Code Editor

  To view or edit the code, you will need an code editor or text editor. The popular open-source choices for an code editor are Atom and VisualStudio Code.

  1) Code Editor Download:
      * Option 1: [Atom](https://nodejs.org/en/)
      * Option 2: [VisualStudio Code](https://www.npmjs.com/)
  2) Click the download most applicable to your OS and system.
  3) Wait for download to complete, then install -- Windows will run the setup exe and macOS will drag and drop into applications.
  4) Optionally, create a [GitHub Account](https://github.com)


### ⚙️ Setup and Use

  #### Cloning

  1) Navigate to the [Discord Bot repository here](https://github.com/Pingel88/TravisScottDiscordBot.Solution).
  2) Click 'Clone or download' to reveal the HTTPS url ending with .git and the 'Download ZIP' option.
  3) Open up your system Terminal or GitBash, navigate to your desktop with the command: `cd Desktop`, or whichever location suits you best.
  4) Clone the repository to your desktop: `$ git clone https://github.com/Pingel88/TravisScottDiscordBot.Solution.git`
  5) Run the command `cd TravisScottDiscordBot.Solution` to enter into the project directory.
  6) View or Edit:
      * Code Editor - Run the command `atom .` or `code .` to open the project in Atom or VisualStudio Code respectively for review and editing.
      * Text Editor - Open by double clicking on any of the files to open in a text editor.

  #### Download

  1) Navigate to the [Discord Bot repository here](https://github.com/Pingel88/TravisScottDiscordBot.Solution).
  2) Click 'Clone or download' to reveal the HTTPS url ending with .git and the 'Download ZIP' option.
  3) Click 'Download ZIP' and extract.
  4) Open by double clicking on any of the files to open in a text editor.

  #### EnvironmentVariables

  1) Create a new file in the TravisScottDiscordBot.Solution/Bot/Models directory named `EnvironmentVariables.cs`.
  2) Add the following code snippet to the new EnvironmentVariables.cs file:

      ```
      namespace Bot.Models
      {
        public static class EnvironmentVariables
        {
          public static string ApiKey = "[YOUR API KEY]";

          public static string BotToken = "[YOUR BOT TOKEN]";
        }
      }
      ```
  3) Please note that you will have to replace the `[YOUR API KEY]` and `[YOUR BOT TOKEN]` placeholders with your own bot token and API key. Follow along with the next instructions to obtain them.
  
  #### Acquire API Key

  1) [Create an account](https://rapidapi.com/auth/sign-up) with RapidAPI in order to obtain an API key. 
  2) Visit the [pricing tab](https://rapidapi.com/KegenGuyll/api/dad-jokes/pricing) for the Dad Jokes page to subscribe to the API. The free tier should suffice for testing purposes. 
  3) Next, navigate to the [endpoints tab](https://rapidapi.com/KegenGuyll/api/dad-jokes/endpoints) to obtain your API key -- you will have to copy it from the code snippets in the panel on the right.
  4) Replace the placeholder text in your EnvironmentVariables.cs file with the API key.

  #### Acquire Bot Token

  1) You will have to sign in with your discord account in order to create a new bot app. If you don't have one already, sign up [here](https://discord.com/).
  2) [This link](https://discord.com/developers/applications) will take you to the developers dashboard to begin setting up your dad joke bot. 
      * Select new application.
      * Name the application.
      * Select `Bot` on the left.
      * Select `Add Bot` on the right.
      * Select `Yes, do it!`.
  3) To acquire the bot token, click on `Copy` under **Build-A-Bot** to copy your token to your clipboard.
  4) Replace the placeholder text in your EnvironmentVariables.cs file with your bot token.

  #### Launch Application

  With your environment variables in place, you are only a few terminal commands away from launching the bot.
  1) In the TravisScottDiscordBot.Solution/Bot repository,
      * Enter `dotnet restore` in your terminal.
      * Next, enter `dotnet run` in your terminal.
  2) Next, invite the bot to your server, Back in the [Developers Dashboard](https://discord.com/developers/applications), apply the following steps:
      * Select `OAuth2` on the left.
      * Select `Bot` under scopes.
      * Select `Send Messages` under **Text Permissions** inside of **Bot Permissions**.
  3) Copy the **URL** at the bottom of **Scopes**, and paste into the browser to invite the bot to servers you are an Admin of.

## 🛰️ Add OUR Bot

1) [Click here](https://discord.com/api/oauth2/authorize?client_id=828681816235180082&permissions=2048&scope=bot)
2) If you are not logged in to Discord already, go ahead and do that now. 
3) Select the server you wish to add the Bot to. 
4) Click `Continue`.
5) Click `Authorize`.
6) Enjoy!


------------------------------

### 🤝 Contributors

| Author | GitHub | Email |
|--------|:------:|:-----:|
| [Mike Pingel](https://www.linkedin.com/in/mikepingel/) | [Pingel88](https://github.com/Pingel88) | [mdpingel@gmail.com](mailto:mdpingel@gmail.com) |
| [Morgan Bradford](https://www.linkedin.com/in/morganjbradford/) | [MorganJBradford](https://github.com/MorganJBradford) | [morganjbradford95@gmail.com](mailto:morganjbradford95@gmail.com) |
| [Levi Kohler](https://www.linkedin.com/in/levikohler/) | [levi-kohler](https://github.com/levi-kohler) | [kohler.la01@gmail.com](mailto:kohler.la01@gmail.com) |
| [Jeroen van Seeters](https://linkedin.com/in/jeroenvanseeters) | [Jeroenemo](https://github.com/jeroenemo) |  [vanseetersjeroen@gmail.com](mailto:vanseetersjeroen@gmail.com) |

------------------------------

### ✉️ Contact and Support

If you have any feedback or concerns, please contact one of the contributors.

<p>
  <a href="https://github.com/Pingel88/TravisScottDiscordBot.Solution/issues">Report Bug</a> ·
  <a href="https://github.com/Pingel88/TravisScottDiscordBot.Solution/issues">Request Feature</a>
</p>

------------------------------

### ⚖️ License

This project is licensed under the [MIT License](https://opensource.org/licenses/MIT). Copyright (C) 2021 Mike Pingel, Morgan Bradford, Levi Kohler, Jeroen van Seeters. All Rights Reserved.

```
MIT License

Copyright (c) 2021 Mike Pingel, Morgan Bradford, Levi Kohler, Jeroen van Seeters.

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```

------------------------------

### 🌟 Acknowledgments

#### [Epicodus](https://www.epicodus.com/)
>"A school for tech careers... to help people learn the skills they need to get great jobs."

#### [The Internet](https://webfoundation.org/)
> "...the first thing that humanity has built that humanity doesn't understand..."
> - Eric Schmidt, Google (Alphabet Inc.)

------------------------------

<center><a href="#">Return to Top</a></center>