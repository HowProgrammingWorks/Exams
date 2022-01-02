// Validate person name

const Valid = (name) => {
if (name === '') return false;
if (typeof name !== 'string') return false;
for (words of name) {
    if (words === ' ') continue;
    if (words.toLowerCase().charCodeAt(0) >= 97 && words.toLowerCase().charCodeAt(0) <= 122) { } else { return false; }
  };
  return true;
};

const result = Valid('Marcus Aurelius');
console.log(result);
