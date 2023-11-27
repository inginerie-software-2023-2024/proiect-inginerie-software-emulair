# Emulair

## Project Requirements
Emulair is an Android exclusive open-source front-end for Libretro cores, based on [Lemuroid](https://github.com/Swordfish90/Lemuroid). The primary goal of Emulair is to combine the ease of use and simple but accessible interface of Lemuroid with RetroArch's extensive customizability and features, while also adding support for standalone emulators.

The web version of Emulair is a website created for users and developers so they can keep up with important news about our projects, find tutorials for how to use Emulair, read relevant documentation for how to contribute code and, in the future, run lightweight versions of some popular emulators directly from their web browsers.

For more information about the projects (such as the **features**, **user stories**, **user personas**, etc.), check this [Wiki page](https://github.com/inginerie-software-2023-2024/proiect-inginerie-software-emulair/wiki), the [Android Wiki page](https://github.com/Emulair/Emulair-Androi/wiki/4.-SWE-Project-Requirements) or the [web Wiki page](https://github.com/Emulair/Emulair-Web/wiki/3.-SWE-Project-Requirements).

To see our **backlogs**, check the original [Android Projects page](https://github.com/orgs/Emulair/projects/1) and [web Projects page](https://github.com/orgs/Emulair/projects/2).

## User Stories for the Initial Project (Android)
The original user stories canbe accessed here: https://github.com/Emulair/Emulair-Android/wiki/3.-SDM-project-requirements. All of our initial user stories have been implemented.

## SDM - Original Team Description (Android)
Radu-George Bratan: Android team lead, Android developer, designer
Eduard Gabriel Cristea: Android developer
Eduard Marian Marin Florin: Android developer
Diana Elena Gisca: Android developer
Valentian Adrian Nafornita: Android developer

## SWE - New Team Description (Android and Web)
Radu-George Bratan: Android team lead, Android developer, designer
Eduard Marian Marin Florin: Android developer
Cosmin Colceru: Android developer
Eduard Gabriel Cristea: web team lead, web developer, designer
Alexandru Antonio Petrescu: web developer, designer
Mihai Catalin Grigore: web developer

## Software Architecture Report (Android)
Q: What are the technologies that you have used, and why?<br />
A: We used Kotlin and XML as languages because that's what the original project was written in and was easier to continue with those (Emulair is a fork of Lemuroid, as stated [here](https://github.com/Emulair/Emulair-Android#origin)).

Q: What are the architectural patterns you have implemented and were they appropriate, and why?<br />
A: We used MVVM as our primary architctural pattern because not only is this the industry standard, but also because it's sufficiently easy to grasp and extremely useful once mastered.

Q: Were the coding principles established enforced successfully?<br />
A: Yes. We discussed about what principles to used (naming conventions, code styles, etc) and followed them.

Q: What are the faults that were discovered during development that haven’t been addressed by the time of delivery?<br />
A: Here are some bugs that we encountered: https://github.com/Emulair/Emulair-Android/issues?q=is%3Aissue+is%3Aopen+sort%3Aupdated-desc+label%3Abug

Q: Does any part of the project require refactoring?<br />
A: Right now, no, but in the future, it will.

## State Diagram (Android and Web)
[adding_favourite_game_from_game_list_flow.pdf](https://github.com/inginerie-software-2023-2024/proiect-inginerie-software-emulair/files/13468557/adding_favourite_game_from_game_list_flow.pdf)
