// Get day number
"use strict";

const days = ["Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"];

const parser = (day) => {
  for (let i = 0; i < days.length; i++) {
    day = day.toLowerCase();
    days[i] = days[i].toLowerCase();
    if (day.startsWith(days[i])) {
      return `match found: ${i + 1}`;
    }
  }
  return `no match: ${-1}`;
}

const result = parser("friday");
console.log(result);
