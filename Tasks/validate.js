'use strict';
// Validate person name

const isValidate = (personName) => {
  if (!personName) return false;
  if (personName.trim().length === 0) return false;
  if (!personName.includes(' ')) return false;
  for (const char of personName) {
    if (char === ' ') continue;
    if (!char.toLowerCase().match(/[a-z]/)) return false;
  }
  return true;
};

require('../Tests/validate.js')(isValidate);
