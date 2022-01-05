

// Validate person name

const isValidate = personName => {
  if (!personName) return false;
  if (typeof personName !== 'string') return false;
  if (!personName.includes(' ')) return false;

  for (const letter of personName) {
    const unicodeIndex = letter.toLowerCase().charCodeAt(0);

    if (letter === ' ') continue;
    if (!(unicodeIndex >= 97 && unicodeIndex <= 122)) return false;
  }

  return true;
};

const result = isValidate('Marcus Aurelius');
console.log(result);
