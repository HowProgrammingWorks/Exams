'use strict';

// Validate person name

const isValidate = (personName) => {
  if (!personName) return false;
  if (typeof personName !== 'string') return false;
  if (!personName.includes(' ')) return false;

  for (const letter of personName) {
    if (letter === ' ') continue;
    if (letter.toLowerCase().charCodeAt(0) >= 97 && letter.toLowerCase().charCodeAt(0) <= 122) { } else { return false; }
  }

  return true;
};

const result = isValidate('Marcus Aurelius');
console.log(result);
