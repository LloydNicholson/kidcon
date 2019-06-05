export function getRandomItem(item: any[]) {
  return item[Math.floor(Math.random() * item.length)];
}
