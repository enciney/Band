using EternalBAND.Data;
using EternalBAND.Models;
using Microsoft.EntityFrameworkCore;

namespace EternalBAND.Business;

public class NotificationProcess
{
    private ApplicationDbContext _context;

    public NotificationProcess(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<bool> SaveNotification(string message, string receiverUserId,string redirectLink, string seo)
    {
        try
        {
            await _context.Notification.AddAsync(new Notification()
            {
                IsRead = false,
                AddedDate = DateTime.Now,
                Message = message,
                ReceiveUserId = receiverUserId,
                RedirectLink = redirectLink,
                // TODO : message's related id is just post now maybe better to give user + post on following time
                RelatedElementId = seo

            });
            await _context.SaveChangesAsync();
            var user = await _context.Users.FirstOrDefaultAsync(n => n.Id == receiverUserId);
            await new MailSender(_context).SendEmailAsync(user.Email, "Yeni Bir Bildirimin Var", message);
            return true;
        }
        catch(Exception ex)//TODO:log
        {
            return false;
        }
    }
}