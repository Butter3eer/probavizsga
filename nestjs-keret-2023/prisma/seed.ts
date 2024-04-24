import { PrismaClient } from '@prisma/client'
const prisma = new PrismaClient()
async function main() {
  for (let i = 0; i < 15; i++) {
    const date = new Date(2024, 2, Math.floor(Math.random() * 30 + 1))
    await prisma.payments.create({
      data : {
        amount : Math.floor(Math.random() * 10000 + 5000),
        paid_at : date,
        member_id : Math.floor(Math.random() * 10 + 1)
      }
    })
  }
}
main()
  .then(async () => {
    await prisma.$disconnect()
  })
  .catch(async (e) => {
    console.error(e)
    await prisma.$disconnect()
    process.exit(1)
  })
