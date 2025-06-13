# AGENTS.md

## Agent Tasks

### docu-agent

- Create DocFX-compatible Markdown documentation in the `./docs` folder.
- **Documentation must be provided in both English and German**:
    - `index.en.md` — English documentation
    - `index.de.md` — German documentation
    - Both files should provide an overview of the solution and its libraries, consistent in structure and content.
- Use proper markdown formatting as specified in `.github/copilot-instructions.md`.
- (Optional) Create or update a `toc.yml` for DocFX navigation, referencing both language versions if supported.
- Code comments and XML documentation remain in English, per `.github/copilot-instructions.md`.

### review-agent

- Initiate a code review for the branch `dev/extending-content`.
    - Compare against the main development branch.
    - Apply `.github/copilot-instructions.md` guidelines for code, documentation, conditional compilation, and markdown style.
    - For markdown documentation, check that both English and German files are present and consistent.

## Prerequisites

- .NET SDK must be installed for build and documentation generation.
- Agents must operate in the Codex environment on the `dev/extending-content` branch.
    - Switch with:
      ```bash
      git fetch
      git checkout dev/extending-content
      ```
- Uno Platform projects must **not** be handled as MAUI projects.

## Additional Notes

- All formatting and content rules from `.github/copilot-instructions.md` apply workspace-wide unless explicitly overridden.
- If DocFX supports multilingual navigation, configure `toc.yml` accordingly.
