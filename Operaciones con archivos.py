import os, shutil

ARCHIVO = "registros.txt"

def crear(archivo=ARCHIVO):
    if os.path.exists(archivo):
        if input(f"'{archivo}' existe. Sobrescribir? (s/N): ").lower() != 's':
            return
    open(archivo, 'w', encoding='utf-8').close()
    print("Archivo creado:", archivo)

def guardar(archivo=ARCHIVO):
    if not os.path.exists(archivo):
        print("Crea el archivo primero.")
        return
    nombre = input("NOMBRE (ENTER para cancelar): ").strip()
    if not nombre:
        print("Cancelado.")
        return
    matricula = input("MATRICULA: ").strip()
    correo = input("CORREO: ").strip()
    telefono = input("TELEFONO: ").strip()
    with open(archivo, 'a', encoding='utf-8') as f:
        f.write(f"NOMBRE: {nombre}\nMATRICULA: {matricula}\nCORREO: {correo}\nTELEFONO: {telefono}\n\n")
    print("Guardado.")

def leer(archivo=ARCHIVO):
    if not os.path.exists(archivo):
        print("No existe el archivo.")
        return
    print("\n--- CONTENIDO ---")
    with open(archivo, 'r', encoding='utf-8') as f:
        print(f.read().rstrip())
    print("--- FIN ---\n")

def actualizar_nombre(archivo=ARCHIVO):
    if not os.path.exists(archivo):
        print("No existe el archivo.")
        return
    viejo = input("Nombre a buscar (exacto): ").strip()
    if not viejo:
        print("Cancelado.")
        return
    nuevo = input("Nombre reemplazo: ").strip()
    if not nuevo:
        print("Cancelado.")
        return
    shutil.copy2(archivo, archivo + ".bak")
    with open(archivo, 'r', encoding='utf-8') as f:
        lines = f.readlines()
    cambios = 0
    for i,l in enumerate(lines):
        if l.startswith("NOMBRE:"):
            if l[len("NOMBRE:"):].strip() == viejo:
                lines[i] = f"NOMBRE: {nuevo}\n"
                cambios += 1
    if cambios:
        with open(archivo, 'w', encoding='utf-8') as f:
            f.writelines(lines)
    print(f"Reemplazados: {cambios} (backup: {archivo}.bak)")

def menu():
    archivo = ARCHIVO
    while True:
        print("\nArchivo:", archivo)
        print("1) crear archivo\n2) guardar registros\n3) leer archivo\n4) actualizar nombre\n5) cambiar archivo\n6) salir")
        op = input("Opción: ").strip()
        if op == '1':
            n = input("Nombre archivo (ENTER para default): ").strip() or archivo
            crear(n); archivo = n
        elif op == '2':
            guardar(archivo)
        elif op == '3':
            leer(archivo)
        elif op == '4':
            actualizar_nombre(archivo)
        elif op == '5':
            n = input("Nuevo archivo: ").strip()
            if n: archivo = n
        elif op == '6':
            break
        else:
            print("Opción inválida.")

if __name__ == "__main__":
    menu()
