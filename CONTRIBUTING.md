# Guía de contribución

Gracias por tu interés en contribuir a TiendaServicios. Este documento resume el flujo recomendado.

## Requisitos previos
- .NET SDK 7.x (y 6.x si ejecutas proyectos net6.0)
- Docker Desktop (opcional para levantar dependencias vía docker-compose)

## Flujo de trabajo
1. Haz un fork del repositorio y crea una rama desde `main`:
   - git checkout -b feat/mi-cambio
2. Compila localmente y corre la solución:
   - dotnet restore
   - dotnet build TiendaServicios.sln
3. Si agregas proyectos de prueba, ejecuta:
   - dotnet test TiendaServicios.sln
4. Sigue las convenciones de código y estilo del proyecto. Evita cambios no relacionados.
5. Abre un Pull Request hacia `main` describiendo:
   - ¿Qué problema resuelve?
   - ¿Cómo lo resuelve? (resumen técnico)
   - Notas de compatibilidad o migración si aplica.

## Estándar de commits
- Usa prefijos como `feat:`, `fix:`, `docs:`, `chore:`, `refactor:`, `test:`.

## Revisión
- Al menos una aprobación es requerida.
- El pipeline de GitHub Actions debe pasar en verde.
