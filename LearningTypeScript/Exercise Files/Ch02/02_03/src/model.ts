let displayName: string = "Jess's standing desk";
let inventoryType: string = "furniture";
let trackingNumber: string = "FD123455";
let createDate: Date = new Date();
let originalCost = 425;

enum InventoryItemType {
  Computer = "computer",
  Furniture = "furniture",
}

interface InventoryItem {
  displayName: string;
  inventoryType: "computer" | "furniture";
  readonly trackingNumber: string;
  createDate: Date;
  originalCost?: number;

  addNote?: (note: string) => string;
}

function getInventoryItem(trackingNumber: string): InventoryItem | null {
  return null;
}

function saveInventoryItem(item: InventoryItem) {}

let inventoryItem = getInventoryItem(trackingNumber);

let updatedInventoryItem = inventoryItem;

inventoryItem!.createDate = new Date(); // to ensure to the compiler that inventoryItem will always be not null

saveInventoryItem({
  displayName: "MacBook Pro 15 Retina",
  inventoryType: "computer",
  trackingNumber: "MBP123456",
  createDate: new Date(),
});
