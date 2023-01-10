"use strict";
// Validate person name

const isValidate = (personName) => {
  if (!personName) return false;
  if (personName.length === 0) return false;
  if (!personName.includes(' ')) return false;
  {
    for (const char of personName) {
      if (char === ' ') continue;
      if (
        char.toLowerCase().charCodeAt(0) >= 97 &&
        char.toLowerCase().charCodeAt(0) <= 122
      ) {
      } else {
        return false;
      }
    }
    return true;
  }
};

require('../Tests/validate.js')(isValidate);
