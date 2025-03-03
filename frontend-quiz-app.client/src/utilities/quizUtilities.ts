import { TextEncryptedData } from "../api";

const generateKey = async () => {
  return await crypto.subtle.generateKey(
    { name: "AES-GCM", length: 256 },
    true,
    ["encrypt", "decrypt"]
  );
};

const exportKeyBase64 = async (key: CryptoKey) => {
  const exported = await crypto.subtle.exportKey("raw", key);
  return btoa(String.fromCharCode(...new Uint8Array(exported)));
};

const decryptData = async (
  textEncryptedData: TextEncryptedData,
  key: CryptoKey
) => {
  const { encrypted, iv } = textEncryptedData;
  const decoder = new TextDecoder();
  const encryptedBuffer = new Uint8Array(
    atob(encrypted!)
      .split("")
      .map((c) => c.charCodeAt(0))
  );
  const ivBuffer = new Uint8Array(
    atob(iv!)
      .split("")
      .map((c) => c.charCodeAt(0))
  );

  const decryptedBuffer = await crypto.subtle.decrypt(
    { name: "AES-GCM", iv: ivBuffer },
    key,
    encryptedBuffer
  );

  return decoder.decode(decryptedBuffer);
};

export { generateKey, exportKeyBase64, decryptData };
