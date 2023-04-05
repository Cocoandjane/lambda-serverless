# Markdown Notes Posting Application

This repository contains the code for a full-stack, serverless application that allows users to post Markdown notes.

## Backend

The backend is developed with AWS Lamda serverless API, ASP.NET, and C#. The app uses AWS-cognito for authentication and Cockroach-DB for database management.

## Frontend

Front end is built with Next.js. The app uses markdown.js to convert markdown to html and tailwind for styling.

## Markdown Syntax

To create a new note, use Markdown syntax to format your text. Some examples of Markdown syntax include:

- Headings: use a hash symbol (#) at the beginning of a line, with one hash for Heading 1, two hashes for Heading 2, and so on. Example: `# Heading 1`
- Bold: use two asterisks (\*\*) or two underscores (\_\_) before and after the text to be bolded. Example: `**bold text**`
- Italics: use one asterisk (\*) or one underscore (\_) before and after the text to be italicized. Example: `*italicized text*`
- Lists: use hyphens (-) or asterisks (\*) before each item in a list. Example: `- list item`
- Code blocks: use three backticks (\`\`\`) before and after the code to create a code block. Example:

For more information on Markdown syntax, refer to the [Markdown Guide](https://www.markdownguide.org/).

