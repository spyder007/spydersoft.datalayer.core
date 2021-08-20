# Spydersoft.Datalayer.Core

[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]
[![LinkedIn][linkedin-shield]][linkedin-url]
[![Build Status][build-shield]][build-url]
[![Code Climate Score][codeclimate-shield]][codeclimate-url]
## Purpose

This class library provides the basic interfaces and classes necessary to support a storage-agnostic data layer with observable data items. 

The main interfaces are **IDataItem** and **IDataStore**, with the latter providing the contract for CRUD operations on the former.  **DataItem** is a basic implementation of **IDataItem** which provides functions to raise the **ValueChanged** event in derived classes.

The **Attributes** namespace provides ORM-agnostic attributes for marking up instances of **IDataItem** for **IDataStore** instances to use for data store initialization and CRUD operations.

## Examples

[spydersoft.datalayer.core.entityframework](https://github.com/spyder007/spydersoft.datalayer.core.entityframework) is an implementation of **IDataStore** which utilizes EntityFramework.Core for CRUD operations on a SQL database.  Ideas for additional implementations include implementations for SQLite, couchDB, MongoDB, or even basic file-based JSON or XML storage.


Please see the full project [documentation](https://spyder007.github.io/spydersoft.datalayer.core/).


<!-- ROADMAP -->
## Roadmap

See the [open issues](https://github.com/spyder007/pi-monitoring/issues) for a list of proposed features (and known issues).


<!-- CONTRIBUTING -->
## Contributing

Contributions are what make the open source community such an amazing place to be learn, inspire, and create. Any contributions you make are **greatly appreciated**.

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE` for more information.



<!-- CONTACT -->
## Contact

Matt Gerega - geregam@gmail.com

Project Link: [https://github.com/spyder007/pi-monitoring](https://github.com/spyder007/pi-monitoring)


<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/spyder007/spydersoft.datalayer.core.svg?style=for-the-badge
[contributors-url]: https://github.com/spyder007/spydersoft.datalayer.core/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/spyder007/spydersoft.datalayer.core.svg?style=for-the-badge
[forks-url]: https://github.com/spyder007/spydersoft.datalayer.core/network/members
[stars-shield]: https://img.shields.io/github/stars/spyder007/spydersoft.datalayer.core?style=for-the-badge
[stars-url]: https://github.com/spyder007/spydersoft.datalayer.core/stargazers
[issues-shield]: https://img.shields.io/github/issues/spyder007/spydersoft.datalayer.core.svg?style=for-the-badge
[issues-url]: https://github.com/spyder007/spydersoft.datalayer.core/issues
[license-shield]: https://img.shields.io/github/license/spyder007/spydersoft.datalayer.core.svg?style=for-the-badge
[license-url]: https://github.com/spyder007/spydersoft.datalayer.core/blob/main/LICENSE
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/geregam
[build-shield]: https://img.shields.io/github/workflow/status/spyder007/spydersoft.datalayer.core/Library%20Build%20and%20Publish?style=for-the-badge
[build-url]: https://github.com/spyder007/spydersoft.datalayer.core/actions/workflows/dotnet-core.yml
[codeclimate-shield]: https://img.shields.io/codeclimate/maintainability/spyder007/spydersoft.datalayer.core?style=for-the-badge
[codeclimate-url]: https://codeclimate.com/github/spyder007/spydersoft.datalayer.core