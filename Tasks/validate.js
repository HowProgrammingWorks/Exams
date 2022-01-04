// Validate person name
'use strict'

const isValid = (name) => {
    if (name === '') return false;
    if (typeof (name) !== 'string') return false;
    if (!name.includes(' ')) return false;
    for (const char of name) {
        if (char === ' ') continue;
        const charCode = char.toLowerCase().charCodeAt(0);
        if (charCode < 97 || charCode > 122) return false;
    }
    return true;
}

const result = isValid('Marcus Aurelius');
const result2 = isValid('NoLastName');
const result3 = isValid('Markus Pers@n');

console.log(result);
console.log(result2);
console.log(result3);
