export function initialize() {
    let IndexedDb = indexedDB.open(DATABASE_NAME, CURRENT_VERSION);
    IndexedDb.onupgradeneeded = function () {
        let db = IndexedDb.result;
        db.createObjectStore("User", { keyPath: "Id" });
        db.createObjectStore("WeightMeasurement", { keyPath: "Id" });
        db.createObjectStore("UnitOfMeasurement", { keyPath: "Id" });
    }
}

let CURRENT_VERSION = 1;
let DATABASE_NAME = "IndexedDb";

export function set(collectionName, value) {
    let IndexedDb = indexedDB.open(DATABASE_NAME, CURRENT_VERSION);

    IndexedDb.onsuccess = function () {
        let transaction = IndexedDb.result.transaction(collectionName, "readwrite");
        let collection = transaction.objectStore(collectionName)
        collection.put(value);
    }
}

export async function get(collectionName, id) {
    let request = new Promise((resolve) => {
        let IndexedDb = indexedDB.open(DATABASE_NAME, CURRENT_VERSION);
        IndexedDb.onsuccess = function () {
            let transaction = IndexedDb.result.transaction(collectionName, "readonly");
            let collection = transaction.objectStore(collectionName);
            let result = collection.get(id);

            result.onsuccess = function (e) {
                resolve(result.result);
            }
        }
    });

    let result = await request;

    return result;
}